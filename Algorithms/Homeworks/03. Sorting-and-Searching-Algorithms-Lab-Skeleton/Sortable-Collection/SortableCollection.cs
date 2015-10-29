namespace Sortable_Collection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Sortable_Collection.Contracts;

    public class SortableCollection<T> where T : IComparable<T>
    {
        public SortableCollection()
        {
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.Items = new List<T>(items);
        }

        public SortableCollection(params T[] items)
            : this(items.AsEnumerable())
        {
        }

        public List<T> Items { get; } = new List<T>();

        public int Count => this.Items.Count;

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.Items);
        }

        public int BinarySearch(T item)
        {
            return BinarySearchProcedure(item, 0, this.Items.Count - 1);
        }

        private int BinarySearchProcedure(T item, int startIndex, int endIndex)
        {
            if (endIndex < startIndex)
            {
                return -1;
            }

            int midpoint = startIndex + (endIndex - startIndex) / 2;
            if (this.Items[midpoint].CompareTo(item) > 0)
            {
               return midpoint = BinarySearchProcedure(item, 0, midpoint - 1);
            }

            if (this.Items[midpoint].CompareTo(item) < 0)
            {
                return midpoint = BinarySearchProcedure(item, midpoint + 1, endIndex);
            }

            return midpoint;
        }

        public int InterpolationSearch(int item)
        {
            List<int> items = new List<int>();
            for (int i = 0; i < this.Items.Count; i++)
            {
                items.Add(Convert.ToInt32(this.Items[i]));
            }

            int start = 0;
            int end = this.Count - 1;
            if (start > end)
            {
                return -1;
            }

            while (items[start] <= item && items[end] >= item)
            {
                int mid = start + (((item - items[start]) * (end - start)) / (items[end] - items[start]));
                if (items[mid] > item)
                {
                    end = mid - 1;
                }
                else if (items[mid] < item)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public void Shuffle()
        {
            Random random = new Random();

            int len = this.Items.Count;
            for (int i = 0; i < len; i++)
            {
                int r = i + random.Next(0, len - i);
                var temp = this.Items[i];
                this.Items[i] = this.Items[r];
                this.Items[r] = temp;
            }
        }

        public T[] ToArray()
        {
            return this.Items.ToArray();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Items)}]";
        }        
    }
}