using System;
using System.Collections.Generic;
using System.Linq;

namespace Closures
{
    public class Program
    {
        public struct MyStruct
        {
            public int Value;
            public string Text;
        }

        public static void Main(string[] args)
        {
            var d1 = AnonymousDelegate();
            Console.WriteLine("AnonymousDelegate: {0}", d1(3));

            var a1 = Lambda();
            a1(6);

            For();
        }

        public static Func<int, string> AnonymousDelegate()
        {
            int a = 1;

            string b = "MyString";

            var myStruct = new MyStruct
            {
                Value = 2,
                Text = "AnotherString"
            };

            return delegate (int value)
            {
                return (a + myStruct.Value + value).ToString() + myStruct.Text;
            };
        }

        public static Action<int> Lambda()
        {
            MyStruct myStruct;

            int c = 3;

            string d = "MyString";

            myStruct.Value = c;

            return (i) =>
            {
                Console.WriteLine(c.ToString() + d + i.ToString());
            };
        }

        public static void For()
        {
            var actions = new List<Action>();
            int counter = 1;

            foreach (var i in Enumerable.Range(1, 5))
            {
                actions.Add(() => Console.WriteLine(i + ", " + counter));
                counter++;
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
