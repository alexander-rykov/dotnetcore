using System;

namespace Foreach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Method1();
            Method2();
        }

        public static void Method1()
        {
            foreach (var i in new MyClass().GetSequence())
            {
                Console.WriteLine("Method1: {0}", i);
            }
        }

        public static void Method2()
        {
            var anotherClass = new AnotherClass();
            foreach (var i in anotherClass)
            {
                Console.WriteLine("Method2: {0}", i);
            }
        }
    }
}
