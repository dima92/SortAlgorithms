using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort() { }

        public GnomeSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var i = 1;
            while (i < Items.Count)
            {
                if (i == 0 || Compare(Items[i], Items[i - 1]) != -1)
                {
                    i++;
                }
                else
                {
                    Swop(i, i - 1);
                    i--;
                }
            }
        }
    }
}
