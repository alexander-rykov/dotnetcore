using System;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new ManualResetEventSlim(false);
            var pingEvent = new AutoResetEvent(false);
            var pongEvent = new AutoResetEvent(false);

            CancellationTokenSource cts = null; // TODO: Create a new cancellation token source.
            CancellationToken token; // TODO: Assign an appropriate value to token variable.

            Action ping = () =>
            {
                Console.WriteLine("ping: Waiting for start.");
                start.Wait();

                bool continueRunning = true;

                while (continueRunning)
                {
                    Console.WriteLine("ping!");

                    // TODO: write ping-pong functionality here using pingEvent and pongEvent here.

                    Thread.Sleep(1000);

                    continueRunning = true; // TODO: Use cancellation token "token" internals here to set appropriate value.
                }

                // TODO: Fix issue with blocked pong task.

                Console.WriteLine("ping: done");
            };

            Action pong = () =>
            {
                Console.WriteLine("pong: Waiting for start.");
                start.Wait();

                bool continueRunning = true;

                while (continueRunning)
                {
                    Console.WriteLine("pong!");

                    // TODO: write ping-pong functionality here using pingEvent or pongEvent here.

                    Thread.Sleep(1000);

                    // TODO: write ping-pong functionality here using pingEvent or pongEvent here.

                    continueRunning = true; // TODO: Use cancellation token "token" internals here to set appropriate value.
                }

                // TODO: Fix issue with blocked ping task.

                Console.WriteLine("pong: done");
            };


            var pingTask = Task.Run(ping);
            var pongTask = Task.Run(pong);

            Console.WriteLine("Press any key to start.");
            Console.WriteLine("After ping-pong game started, press any key to exit.");
            Console.ReadKey();
            start.Set();

            Console.ReadKey();
            // TODO: cancel both tasks using cancellation token.

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
