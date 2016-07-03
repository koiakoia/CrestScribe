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
        private ManualResetEvent _waitEvent = new ManualResetEvent(false);
        private Thread _thread = null;
        CancellationTokenSource _cts = new CancellationTokenSource();

        private bool _shutdown = false;

        public ScribeService()
        {
            InitializeComponent();
        }

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
            _shutdown = true;
            _cts.Cancel();
            _waitEvent.Set();
            if (!_thread.Join(10000))
            {
                _thread.Abort();
            }
        }

        private void workThread()
        {
            var newCharacters = new BlockingCollection<SsoCharacter>();
            var taskList = new List<Task>();

            DateTime createdCutoff = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);

            while (!_shutdown)
            {
                _waitEvent.Reset();

                var characters = Database.GetSSOCharacters(createdCutoff);
                foreach (var c in characters)
                {
                    newCharacters.Add(c);
                }
                createdCutoff = DateTime.UtcNow;

                foreach (var character in newCharacters.GetConsumingEnumerable())
                {
                    var task = PeriodicTask.Run(async () => { await character.Update(); }, new TimeSpan(0, 0, 0, ScribeSettings.Settings.CrestLocation.Interval), _cts.Token);

                    taskList.Add(task);
                }

                _waitEvent.WaitOne(60000);
            }

            if(_shutdown)
            {
                Task.WaitAll(taskList.ToArray());
            }
        }
    }
}
