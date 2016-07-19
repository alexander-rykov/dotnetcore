using System;
using System.Collections.Generic;
using System.Threading;

namespace ReadWrite
{
    class Program
    {
        // TODO: replace Object type with appropriate type for slim version of manual reset event.
        private static IList<Thread> CreateWorkers(Object mres, Action action, int threadsNum, int cycles)
        {
            var threads = new Thread[threadsNum];

            for (int i = 0; i < threadsNum; i++)
            {
                Action d = () =>
                {
                    // TODO: Wait for signal.

                    for (int j = 0; j < cycles; j++)
                    {
                        action();
                    }
                };

                Thread thread = null; // TODO: Create a new thread that will run the delegate above here.

                threads[i] = thread;
            }

            return threads;
        }

        static void Main(string[] args)
        {
            var list = new MyList();

            // TODO: Replace Object type with slim version of manual reset event here.
            Object mres = null;

            var threads = new List<Thread>();

            threads.AddRange(CreateWorkers(mres, () => { list.Add(1); }, 10, 100));
            threads.AddRange(CreateWorkers(mres, () => { list.Get(); }, 10, 100));
            threads.AddRange(CreateWorkers(mres, () => { list.Remove(); }, 10, 100));

            foreach (var thread in threads)
            {
                // TODO: Start all threads.
            }

            Console.WriteLine("Press any key to run unblock working threads.");
            Console.ReadKey();

            // NOTE: When an user presses the key all waiting worker threads should begin their work.
            // TODO: Send a signal to all worker threads that they can run.

            foreach (var thread in threads)
            {
                // TODO: Wait for all working threads
            }

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}
