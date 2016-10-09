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


namespace borkedLabs.CrestScribe
{
    public partial class ScribeService : ServiceBase
    {
   //     private ManualResetEvent _waitEvent = new ManualResetEvent(false);
        private Thread _thread = null;
        CancellationTokenSource _cts = new CancellationTokenSource();

        private bool _shutdown = false;

        private List<ScribeQueryWorker> _queryWorkers = new List<ScribeQueryWorker>();


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

            for (int i = 0; i < 15; i++)
            {
                var queryWorker = new ScribeQueryWorker(_queryQueue, _cts.Token);
                _queryWorkers.Add(queryWorker);

                queryWorker.Start();
            }
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
            _shutdown = true;
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

            while (!_cts.Token.IsCancellationRequested)
            {
                var characters = Database.GetSSOCharacters(createdCutoff);

                int i = 0;
                foreach (var character in characters)
                {
                    character.QueryQueue = _queryQueue;
                    _queryQueue.Add(character);

                    i++;
                    if (i > 20)
                    {
                        i = 0;
                        Thread.Sleep(1000);
                    }
                }

                if(characters.Count > 0)
                {
                    createdCutoff = DateTime.UtcNow;
                }

                _cts.Token.WaitHandle.WaitOne(60000);
            }

            if(_shutdown)
            {
                foreach (var w in _queryWorkers)
                {
                    w.Thread.Join(500);
                }
            }
        }
    }
}
