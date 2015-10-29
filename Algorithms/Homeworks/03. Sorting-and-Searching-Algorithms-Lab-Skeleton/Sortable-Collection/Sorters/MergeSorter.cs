namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            var tempArray = new T[collection.Count];
            this.MergeSort(collection, tempArray, 0, collection.Count - 1);
        }

        private void MergeSort(List<T> collection, T[] tempArray, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                this.MergeSort(collection, tempArray, start, middle);
                this.MergeSort(collection, tempArray, middle + 1, end);

                this.Merge(collection, tempArray, start, middle, end);
            }
        }

        private void Merge(List<T> collection, T[] tempArray, int start, int middle, int end)
        {
            int leftStart = start;
            int rightStart = middle + 1;
            int tempIndex = 0;

            while (leftStart <= middle && rightStart <= end)
            {
                if (collection[leftStart].CompareTo(collection[rightStart]) <= 0)
                {
                    tempArray[tempIndex++] = collection[leftStart++];
                }
                else
                {
                    tempArray[tempIndex++] = collection[rightStart++];
                }
            }

            while (leftStart <= middle)
            {
                tempArray[tempIndex++] = collection[leftStart++];
            }

            while (rightStart <= end)
            {
                tempArray[tempIndex++] = collection[rightStart++];
            }

            leftStart = start;
            tempIndex = 0;

            while (tempIndex < tempArray.Length && leftStart <= end)
            {
                collection[leftStart] = tempArray[tempIndex];
                tempIndex++;
                leftStart++;
            }
        }
    }
}
