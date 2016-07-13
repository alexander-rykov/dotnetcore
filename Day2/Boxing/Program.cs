using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Boxing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SimpleBoxingExample();
            //WriteLine();
            //WriteLineToString();
            //Delegate();
            //AnonymousDelegate();
            //Action();
            //Interface();
            IterateIlist();
            IterateList();
            //Enum();

            Console.ReadKey();
        }

        static Program()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _strings.Add(i.ToString());
            }
        }

        #region Boxing / unboxing example

        public static void SimpleBoxingExample()
        {
            int value = 15;

            object obj = value;

            int value2 = (int)obj; // NOTE: Show this code in ILSpy.
        }

        #endregion

        #region Console.WriteLine

        public static void WriteLine()
        {
            Console.WriteLine("Value is {0}", 15);
        }

        public static void WriteLineToString()
        {
            Console.WriteLine("Value is {0}", 15.ToString());
        }

        #endregion

        #region Delegate

        public delegate void MyDelegate();

        public struct MyStruct
        {
            public int Value;

            public MyStruct(int value)
            {
                Value = value;
            }

            public void Increment()
            {
                Console.WriteLine("Before: {0}", Value.ToString());
                Value += 1;
                Console.WriteLine("After: {0}", Value.ToString());
            }
        }

        public static void Delegate()
        {
            MyStruct myStruct = new MyStruct(10);

            myStruct.Increment();
            MyDelegate increment = new MyDelegate(myStruct.Increment);
            increment();
            myStruct.Increment();
        }

        #endregion

        #region Anonymous delegate

        public static void AnonymousDelegate()
        {
            MyStruct myStruct = new MyStruct(20);

            myStruct.Increment();
            Action increment = new Action(delegate { myStruct.Increment(); });
            increment();
            myStruct.Increment();
        }

        #endregion

        #region Action

        public static void Action()
        {
            MyStruct myStruct = new MyStruct(30);

            myStruct.Increment();
            Action increment = myStruct.Increment;
            increment();
            myStruct.Increment();
        }

        #endregion

        #region Interface

        public interface IAnotherStruct
        {
            void DoSomething();
        }

        public struct AnotherStruct : IAnotherStruct
        {
            public int Value;

            public void DoSomething()
            {
                Console.WriteLine("Value is {0}", Value);
                Value++;
            }
        }

        public static void Interface()
        {
            var anotherStruct = new AnotherStruct();
            (anotherStruct as IAnotherStruct).DoSomething();
            anotherStruct.DoSomething();
        }

        #endregion

        #region Iterate IList/list

        // NOTE: https://www.youtube.com/watch?v=HG_Tmq77Nxo

        private static List<string> _strings = new List<string>();

        public static IList<string> GetStrings()
        {
            return _strings;
        }

        public static void IterateIlist()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {
                foreach (var value in GetStrings())
                {
                    // Just iterate
                }

            }

            stopwatch.Stop();
            Console.WriteLine("IterateIlist: {0}ms", stopwatch.ElapsedMilliseconds);
        }

        public static void IterateList()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {
                foreach (var value in _strings)
                {
                    // Just iterate
                }
            }

            stopwatch.Stop();
            Console.WriteLine("IterateList: {0}ms", stopwatch.ElapsedMilliseconds);
        }

        #endregion

        #region Enum

        public enum MyEnum
        {
            One
        }

        public static void Enum()
        {
            var hashtable = new Hashtable();
            hashtable["One"] = MyEnum.One;
            Console.WriteLine((MyEnum)hashtable["One"]);
        }

        #endregion
    }
}