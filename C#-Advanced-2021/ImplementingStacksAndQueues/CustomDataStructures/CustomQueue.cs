using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomDataStructures
{
    class CustomQueue
    {
        private const int initialCapacity = 4;
        private const int firstElementIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            count = 0;
            items = new int[initialCapacity];
        }

        public int Count => count;

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                IncreaseSize();
            }

            items[count] = item;
            count++;
        }

        private void IncreaseSize()
        {
            int[] tempArray = new int[items.Length * 2];
            items.CopyTo(tempArray, 0);
            items = tempArray;
        }

        public int Dequeue()
        {
            IsEmpty();
            count--;
            var firstElement = items[firstElementIndex];
            SwitchElements();
            return firstElement;
        }

        private void SwitchElements()
        {
            items[firstElementIndex] = default;

            for (int i = 1; i < items.Length; i++)
            {
                items[i - 1] = items[i];
            }

            items[items.Length - 1] = default;
        }

        private void IsEmpty()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
        }

        public int Peek()
        {
            IsEmpty();
            var lastElement = this.count - 1;
            int last = this.items[lastElement];
            return last;
        }

        public void Clear()
        {
            IsEmpty();
            Array.Clear(items, 0, items.Length);
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
