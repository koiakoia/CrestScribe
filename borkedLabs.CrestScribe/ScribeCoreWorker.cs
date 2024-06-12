﻿using NLog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using borkedLabs.CrestScribe.Database;
using StackExchange.Redis;

namespace borkedLabs.CrestScribe
{
    public static class ScribeCoreWorker
    {
        private static BlockingCollection<CharacterMaintainer> _queryQueue = new BlockingCollection<CharacterMaintainer>();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static CancellationTokenSource _cts = new CancellationTokenSource();
        private static CancellationTokenSource _workerCts = new CancellationTokenSource();

        private static List<ScribeQueryWorker> _queryWorkers = new List<ScribeQueryWorker>();

        private static ConcurrentDictionary<string, CharacterMaintainer> Characters = new ConcurrentDictionary<string, CharacterMaintainer>();
        private static Thread _thread = null;
        public static ConnectionMultiplexer Redis = null;

        public static void StartWork()
        {
            if (_thread != null)
                return;

            _thread = new Thread(_workThread);
            _thread.Name = "scribe service thread";
            _thread.IsBackground = true;
            _thread.Start();

            CommandBus.Start();
        }

        public static void StopWork()
        {
            CommandBus.Stop();

            _cts.Cancel();
            _thread.Join(10000);
        }

        public static CharacterMaintainer GetCharacter(string charOwnerHash)
        {
            CharacterMaintainer character = null;
            lock (Characters)
            {
                if(Characters.ContainsKey(charOwnerHash))
                {
                    character = Characters[charOwnerHash];
                }
            }
            return character;
        }

        /// <summary>
        /// Main worker thread that grabs characters and spawns processing tasks
        /// Ideally we rewrite this to have a fixed number of worker threads
        /// so that we can better control our http request spam....
        /// </summary>
        private static void _workThread()
        {
            DateTime createdCutoff = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
            logger.Info("Starting service");
            Redis = ConnectionMultiplexer.Connect(ScribeSettings.Settings.Redis.ConnectionString);

            while (!_cts.Token.IsCancellationRequested)
            {
                bool dbAvaliable = true;
                List<UserSsoCharacter> characters = null;

                try
                {
                    characters = SqlContext.GetSSOCharacters(createdCutoff);
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0: //no connect
                        case (int)MySql.Data.MySqlClient.MySqlErrorCode.UnableToConnectToHost:
                            dbAvaliable = false;
                            break;
                    }
                }

                if (dbAvaliable)
                {
                    //database up?
                    //do we have workers
                    //create them if they don't exist!
                    if (_queryWorkers.Count == 0)
                    {
                        logger.Info("Database is up, restarting threads");
                        //reset the token as it may be triggered
                        _workerCts = new CancellationTokenSource();
                        for (int i = 0; i < ScribeSettings.Settings.Worker.Total; i++)
                        {
                            var queryWorker = new ScribeQueryWorker(_queryQueue, _workerCts.Token);
                            _queryWorkers.Add(queryWorker);

                            queryWorker.Start();
                        }
                    }

                    lock(Characters)
                    {

                        logger.Info("Adding {0} characters to query queue", characters.Count());
                        foreach (var character in characters)
                        {
                            var wrapper = new CharacterMaintainer(character);
                            wrapper.QueryQueue = _queryQueue;
                            if (Characters.TryAdd(character.CharacterOwnerHash, wrapper))
                            {
                                _queryQueue.Add(wrapper);
                            }
                            else
                            {
                                //this shouldnt have happened
                                logger.Error("Exception attempting to add duplicate character {0} to dictionary", character.CharacterId);
                            }
                        }
                    }

                    if (characters.Count > 0)
                    {
                        createdCutoff = DateTime.UtcNow;
                    }
                }
                else
                {
                    //db is down, we should close the workers
                    if (_queryWorkers.Count != 0)
                    {
                        logger.Error("Database is down, killing workers");
                        _workerCts.Cancel();
                        foreach (var w in _queryWorkers)
                        {
                            if (!w.Thread.Join(1500))
                            {
                                logger.Error("Thread failed to join within alloted time");
                            }
                        }

                        _queryWorkers.Clear();
                        lock(Characters)
                        {
                            Characters.Clear();
                        }
                        createdCutoff = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);

                        _queryQueue.Dispose();
                        _queryQueue = new BlockingCollection<CharacterMaintainer>();
                    }
                }

                _cts.Token.WaitHandle.WaitOne(60000);
            }

            logger.Info("Shutting down service");

            _workerCts.Cancel();
            foreach (var w in _queryWorkers)
            {
                if (!w.Thread.Join(500))
                {
                    //really nothing else we can do anyway
                }
            }

            _queryWorkers.Clear();
            Characters.Clear();
        }

    }
}
