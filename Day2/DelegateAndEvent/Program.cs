using System;

namespace DelegateAndEvent
{
    class Program
    {
        public event EventHandler Event;

        public EventHandler Delegate;

        public void Func()
        {
            Delegate = new EventHandler(Method);

            Event += Method;
        }

        public void Method(object o, EventArgs a)
        {
            Console.Write("Test");
        }

        static void Main(string[] args)
        {
            var program = new Program();

            program.Func();

            program.Event(program, EventArgs.Empty);

            program.Delegate(program, EventArgs.Empty);
        }
    }
}
