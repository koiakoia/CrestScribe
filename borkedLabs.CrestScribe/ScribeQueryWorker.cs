using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe
{
    public class ScribeQueryWorker
    {
        private BlockingCollection<SsoCharacter> _queryQueue;
        private CancellationToken _cancelToken;

        public Thread Thread { get; private set; }

        public ScribeQueryWorker(BlockingCollection<SsoCharacter> queryQueue, CancellationToken cancelToken)
        {
            _queryQueue = queryQueue;
            _cancelToken = cancelToken;

            Thread = new Thread(_worker);
            Thread.Name = "scribe query worker";
            Thread.IsBackground = true;
        }

        public void Start()
        {
            Thread.Start();
        }

        private void _worker()
        {
            while (!_cancelToken.IsCancellationRequested)
            {
                var character = _queryQueue.Take(_cancelToken);

                if(character != null)
                {
                    try
                    {
                        var t = Task.Run(character.Poll);
                        t.Wait(_cancelToken);
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        switch (ex.Number)
                        {
                            case 0: //no connect
                            case (int)MySql.Data.MySqlClient.MySqlErrorCode.UnableToConnectToHost:
                                //catch these silently, the main service thread will do magic to cancel out everything
                                break;
                            default:
                                throw ex;
                                break;
                        }
                    }
                }
            }
        }
    }
}
