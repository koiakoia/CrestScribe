using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace borkedLabs.CrestScribe
{
    public partial class ScribeService : ServiceBase
    {
        private ManualResetEvent _waitEvent = new ManualResetEvent(false);
        private Thread _thread = null;

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
            _waitEvent.Set();
            if (!_thread.Join(10000))
            {
                _thread.Abort();
            }
        }

        private void workThread()
        {
            while (!_shutdown)
            {
                _waitEvent.Reset();

                _waitEvent.WaitOne(60000);
            }
        }
    }
}
