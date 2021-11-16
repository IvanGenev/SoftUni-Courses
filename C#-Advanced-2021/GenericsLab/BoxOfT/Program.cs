using System;
using System.Collections.Generic;

namespace BoxOfT
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            box.Add("Ivan");
            box.Add("Teo");
            box.Add("Niki");
            box.Remove("Teo");
        }
    }

    class Box<T>
    {
        private List<T> internalList = new List<T>();

        public void Add(T element)
        {
            internalList.Add(element);
        }

        public int Count => internalList.Count;
       

        public T Remove(T element)
        {
            if (!internalList.Contains(element))
            {
                throw new InvalidOperationException();
            }

            element = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);
            return element;
        }
    }
}
