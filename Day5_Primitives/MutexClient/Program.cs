using System;
using System.Threading;

namespace MutexClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createdNew = false;

            Mutex mutex = null;

            // TODO: mutex = new Mutex(.., "MyMutex", out createdNew);

            Console.WriteLine("MutexClient. Mutex is new? " + createdNew + ". Waiting until mutex will be released.");

            // TODO: wait unit the mutex will be released

            Console.WriteLine("Press any key to release mutex.");
            Console.ReadKey();

            // TODO: release mutex

            Console.WriteLine("Mutex is released. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
