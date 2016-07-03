using System.Threading;

namespace borkedLabs.CrestScribe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ScribeSettings.Load("settings.json");

            //Because VS cannot debug services, we instead change this section to compile
            //the actual service in and out depending on configuration
#if (!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ScribeService()
            };
            ServiceBase.Run(ServicesToRun);
#else
            var service = new ScribeService();
            service.StartWork();

            while (true)
            {
                Thread.Sleep(60000);
            }
#endif
        }
    }
}
