namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        IList<T> arr;
        IList<T> mergedArr;

        public void Sort(IList<T> collection)
        {
            arr = collection;
            mergedArr = new T[collection.Count];
            MergeSort(0, collection.Count - 1);
        }

        void MergeSort(int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
            {
                return;
            }

            int mid = (lowerBound + upperBound) >> 1;

            MergeSort(lowerBound, mid);
            MergeSort(mid + 1, upperBound);
            Merge(lowerBound, mid + 1, upperBound);
        }

        void Merge(int low, int mid, int upper)
        {
            int tempLow = low, tempMid = mid - 1;
            int index = 0;

            while (low <= tempMid && mid <= upper)
            {
                if (arr[low].CompareTo(arr[mid]) < 0)
                {
                    mergedArr[index++] = arr[low++];
                }
                else
                {
                    mergedArr[index++] = arr[mid++];
                }
            }

            while (low <= tempMid)
            {
                mergedArr[index++] = arr[low++];
            }

            while (mid <= upper)
            {
                mergedArr[index++] = arr[mid++];
            }

            for (int i = 0; i < upper - tempLow + 1; i++)
            {
                arr[tempLow + i] = mergedArr[i];
            }
        }
    }
}
