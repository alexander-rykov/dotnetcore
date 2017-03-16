using System;
using System.Threading.Tasks;

namespace GcGenerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new First();

            Console.WriteLine("First is in {0} gen.", GC.GetGeneration(first));
            Console.WriteLine("Press any key to start GC.");
            Console.ReadKey();
            GC.Collect();

            var second = new Second
            {
                First = first
            };

            Console.WriteLine();
            Console.WriteLine("First is in {0} gen.", GC.GetGeneration(first));
            Console.WriteLine("Second is in {0} gen.", GC.GetGeneration(second));
            Console.WriteLine("Press any key to start GC.");
            Console.ReadKey();

            GC.Collect();


            var third = new Third
            {
                First = first,
                Second = second
            };

            Console.WriteLine();
            Console.WriteLine("First is in {0} gen.", GC.GetGeneration(first));
            Console.WriteLine("Second is in {0} gen.", GC.GetGeneration(second));

            var t = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Third is in {0} gen.", GC.GetGeneration(third));
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            });

            t.Wait();
        }
    }
}
