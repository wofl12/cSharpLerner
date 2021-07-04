using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpLerner
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
    }

    public static class BaseCollestionExt
        {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
        }

public class BaseList : IBaseCollection
    {
        private object[] items;

        private int count = 0;

        public BaseList(int initalCapacity)
        {
            items = new object[initalCapacity];
        }

        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
