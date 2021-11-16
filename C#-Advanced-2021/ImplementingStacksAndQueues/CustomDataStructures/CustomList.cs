using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomDataStructures
{
    public class CustomList
    {
        private const int initialCapacity = 2;

        private int[] items;

        public CustomList()
        {
            this.items = new int[initialCapacity];
        }

        public int count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= this.count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public void Add(int item)
        {
            if (this.count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.count] = item;
            this.count++;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.items[index];

            this.items[index] = default(int);

            this.Shift(index);

            this.count--;

            if (this.count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        private void ShiftToRight(int index)
        {
            for (int i = count; i < index; i++)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        public void Insert(int index, int element)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.count == this.items.Length)
            {
                this.Resize();
            }
            this.ShiftToRight(index);
            this.items[index] = element;
            this.count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (items.Contains(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= count
                || secondIndex < 0 || secondIndex >= count)
            {
                throw new IndexOutOfRangeException();
            }

            int tempElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempElement;
        }
    }
}
