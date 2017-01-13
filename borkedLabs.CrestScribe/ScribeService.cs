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
        public ScribeService()
        {
            InitializeComponent();
        }

        public void StartWork()
        {
            ScribeCoreWorker.StartWork();
        }

        public void StopWork()
        {
            ScribeCoreWorker.StartWork();
        }

        protected override void OnStart(string[] args)
        {
            StartWork();
        }

        protected override void OnStop()
        {
            StopWork();
        }
    }
}
