namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        IList<T> arr;

        public void Sort(IList<T> collection)
        {
            arr = collection;
            QuickSort(0, collection.Count - 1);
        }

        void Swap(int index1, int index2)
        {
            T swapValue = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = swapValue;
        }

        void QuickSort(int leftVal, int rightVal)
        {
            if (rightVal - leftVal <= 0)
            {
                return;
            }

            int pivotIndex = Partition(leftVal, rightVal, arr[rightVal]);

            QuickSort(leftVal, pivotIndex - 1);
            QuickSort(pivotIndex + 1, rightVal);
        }

        private int Partition(int leftIndex, int rightIndex, T pivot)
        {
            int currentLeft = leftIndex;
            int currentRight = rightIndex - 1;

            while (true)
            {
                while (arr[currentLeft].CompareTo(pivot) < 0)
                {
                    currentLeft++;
                }

                while (currentRight > 0 && arr[currentRight].CompareTo(pivot) > 0)
                {
                    currentRight--;
                }

                if (currentLeft >= currentRight)
                {
                    break;
                }

                Swap(currentLeft, currentRight);
            }

            Swap(currentLeft, rightIndex);

            return currentLeft;
        }
    }
}
