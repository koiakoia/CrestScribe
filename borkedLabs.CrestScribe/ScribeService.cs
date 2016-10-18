using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using NLog;

namespace borkedLabs.CrestScribe
{
    public partial class ScribeService : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Thread _thread = null;
        CancellationTokenSource _cts = new CancellationTokenSource();
        CancellationTokenSource _workerCts = new CancellationTokenSource();


        private List<ScribeQueryWorker> _queryWorkers = new List<ScribeQueryWorker>();

        private ConcurrentDictionary<UInt64, SsoCharacter> Characters = new ConcurrentDictionary<ulong, SsoCharacter>();


        public ScribeService()
        {
            InitializeComponent();
        }

        private BlockingCollection<SsoCharacter> _queryQueue = new BlockingCollection<SsoCharacter>();

        public void StartWork()
        {
            if (_thread != null)
                return;

            _thread = new Thread(workThread);
            _thread.Name = "scribe service thread";
            _thread.IsBackground = true;
            _thread.Start();
        }

        protected override void OnStart(string[] args)
        {
            StartWork();
        }

        protected override void OnStop()
        {
            StopWork();
        }

        public void StopWork()
        {
            _cts.Cancel();
            if (!_thread.Join(10000))
            {
                _thread.Abort();
            }
        }

        /// <summary>
        /// Main worker thread that grabs characters and spawns processing tasks
        /// Ideally we rewrite this to have a fixed number of worker threads
        /// so that we can better control our http request spam....
        /// </summary>
        private void workThread()
        {
            DateTime createdCutoff = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
            logger.Info("Starting service");

            while (!_cts.Token.IsCancellationRequested)
            {
                bool dbAvaliable = true;
                List<SsoCharacter> characters = null;
                Database.GetConnection();

                try
                {
                    characters = Database.GetSSOCharacters(createdCutoff);
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

                if(dbAvaliable)
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

                    logger.Info("Adding {0} characters to query queue", characters.Count());
                    foreach (var character in characters)
                    {
                        character.QueryQueue = _queryQueue;
                        if (Characters.TryAdd(character.CharacterId, character))
                        {
                            _queryQueue.Add(character);
                        }
                        else
                        {
                            //this shouldnt have happened
                            logger.Error("Exception attempting to add duplicate character {0} to dictionary", character.CharacterId);
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

                                //nuke the thread, really nothing else we can do anyway
                                w.Thread.Abort();
                            }
                        }

                        _queryWorkers.Clear();
                        createdCutoff = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);

                        _queryQueue.Dispose();
                        _queryQueue = new BlockingCollection<SsoCharacter>();
                    }
                }

                _cts.Token.WaitHandle.WaitOne(60000);
            }

            logger.Info("Shutting down service");

            _workerCts.Cancel();
            foreach (var w in _queryWorkers)
            {
                if(!w.Thread.Join(500))
                {
                    //nuke the thread, really nothing else we can do anyway
                    w.Thread.Abort();
                }
            }

            _queryWorkers.Clear();
        }
    }
}
