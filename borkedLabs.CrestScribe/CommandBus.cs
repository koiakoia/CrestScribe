using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using NLog;

namespace borkedLabs.CrestScribe
{
    public static class CommandBus
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static Thread _thread = null;
        private static NetMQPoller _poller = null;

        public static void Start()
        {
            _thread = new Thread(_worker);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public static void Stop()
        {
            if(_poller != null)
            {
                _poller.Stop();
                if(!_thread.Join(1000))
                {
                }
            }
        }

        public class CommandBusMessage
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("parameters")]
            public JObject Parameters { get; set; }
        }

        private static void _handleCommandMessage(CommandBusMessage msg)
        {
            switch(msg.Type)
            {
                case "unfreeze_character":
                    {
                        string charHash = (string)msg.Parameters["character_owner_hash"];

                        if (charHash != "")
                        {
                            var character = ScribeCoreWorker.GetCharacter(charHash);
                            if (character != null)
                            {
                                character.SessionWaitFastFoward();
                            }
                        }
                    }
                    break;
                case "update_sso_character":
                    {
                        string charHash = (string)msg.Parameters["character_owner_hash"];

                        if (charHash != "")
                        {
                            var character = ScribeCoreWorker.GetCharacter(charHash);
                            if (character != null)
                            {
                                character.ResyncWithDatabase();
                            }
                        }
                    }
                    break;
            }
        }

        private static void _worker()
        {
            //socket to receive messages on
            using (var receiver = new PullSocket(ScribeSettings.Settings.CommandBus.ConnectionString))
            using ( _poller = new NetMQPoller { receiver })
            {
                // these event will be raised by the Poller
                receiver.ReceiveReady += (s, a) =>
                {
                    // receive won't block as a message is ready
                    string msg = a.Socket.ReceiveFrameString();

                    try
                    {
                        var msgObj = JsonConvert.DeserializeObject<CommandBusMessage>(msg);
                        _handleCommandMessage(msgObj);
                    }
                    catch(Exception e)
                    {
                        logger.Error(e, "Exception handling command bus message");
                    }

                };

                _poller.Run();
            }
        }
    }
}
