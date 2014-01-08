namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            bool found = false;
            int left = 0;
            int rigth = this.items.Count - 1;
            int middle = rigth / 2;
            while (left <= rigth)
            {
                if (item.CompareTo(items[middle]) == 0)
                {
                    found = true;
                    break;
                }
                if (item.CompareTo(items[middle]) < 0)
                {
                    rigth = middle - 1;
                    middle = (rigth - left) / 2 + left;
                }
                else
                {
                    left = middle + 1;
                    middle = (rigth - left) / 2 + left;
                }
            }

            return found;
        }

        public void Shuffle()
        {
            Random random = new Random();
            T temp;
            int index;
            for (int i = 0; i < items.Count; i++)
            {
                index = random.Next(i, items.Count);
                temp = items[i];
                items[i] = items[index];
                items[index] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}