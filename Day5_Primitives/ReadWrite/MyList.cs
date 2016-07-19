using System;
using System.Collections.Generic;
using System.Threading;

namespace ReadWrite
{
    // TODO: Use ReaderWriterLockSlim to protect this class.
    public class MyList
    {
        private List<int> _list = new List<int>()
        {
            1,
            2,
            3,
            4
        };

        private ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();

        public void Add(int value)
        {
            Console.WriteLine("Write");
            _list.Add(value);
        }

        public void Remove()
        {
            if (_list.Count > 0)
            {
                Console.WriteLine("Write");
                _list.RemoveAt(0);
            }
        }

        public int Get()
        {
            int value = 0;
            if (_list.Count > 0)
            {
                Console.WriteLine("Read");
                value = _list[0];
            }

            return value;
        }
    }
}
