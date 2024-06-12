using System;
using System.Collections;
using System.ServiceProcess;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe
{
    static class Program
    {
        private const string serviceName = "CrestScribe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static async Task Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            ScribeSettings.Load("settings.json");

            ESI.ESIRequestor.Configure();

            //Increase the connection limit which is usually per host in .NET
            System.Net.ServicePointManager.DefaultConnectionLimit = ScribeSettings.Settings.Worker.Total * 2;


            ScribeCoreWorker.StartWork();

            await ConsoleUtil.WaitForShutdownAsync();

            ScribeCoreWorker.StopWork();
        }

    }
}
