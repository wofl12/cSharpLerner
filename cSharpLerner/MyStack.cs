using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpLerner
{
    public class MyStack<T>
    {
        private T[] _items;
        public int Count { get; private set; }
        
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }
        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public MyStack(int capacity)
        {

            _items = new T[capacity];
        }

        public void push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count] = item;
            Count++;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = default(T);
        }
        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }
    }
}
