using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassDemo
{
    class MyList<T>
    {
        T[] _items;
        

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            T[] _tempArray = _items;
            _items = new T[_items.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _items[i] = _tempArray[i];
            }

            _items[_items.Length - 1] = item;
        }

        public void List(T item)
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
