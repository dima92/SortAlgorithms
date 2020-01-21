using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items) { }

        public QuickSort() { }

        protected override void MakeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            // Опорный элемент находится под Right-адресом.
            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }

            Swop(pointer, right);
            return pointer;
        }
    }
}