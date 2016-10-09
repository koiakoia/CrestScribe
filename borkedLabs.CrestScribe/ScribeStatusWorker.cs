using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe
{
    public class ScribeStatusWorker
    {
        private BlockingCollection<SsoCharacter> _queryQueue;
        private BlockingCollection<SsoCharacter> _statusQueue;
        private CancellationToken _cancelToken;

        public Thread Thread { get; private set; }

        public ScribeStatusWorker(BlockingCollection<SsoCharacter> statusQueue, BlockingCollection<SsoCharacter> queryQueue, CancellationToken cancelToken)
        {
            _statusQueue = statusQueue;
            _queryQueue = queryQueue;
            _cancelToken = cancelToken;

            Thread = new Thread(_worker);
            Thread.Name = "scribe status worker";
            Thread.IsBackground = true;
        }

        public void Start()
        {
            Thread.Start();
        }

        private void _worker()
        {
            while(!_cancelToken.IsCancellationRequested)
            {
                var character = _statusQueue.Take(_cancelToken);

                if(character != null)
                {
                    var remainingTime = character.DelayRemainingMilliseconds;
                    if (character.DelayRemainingMilliseconds > 0)
                    {
                        _cancelToken.WaitHandle.WaitOne(character.DelayRemainingMilliseconds);
                    }

                    _queryQueue.Add(character);
                }
            }
        }
    }
}
