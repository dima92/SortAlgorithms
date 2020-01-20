using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixSort() { }

        public RadixSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength();

            for (int step = 0; step < length; step++)
            {
                // Распределение элементов по корзинам.
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                // Сборка элементов.
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                // Очистка корзин.
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            int length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только целые числа(больше либо равно нуля)", nameof(Items));
                }

                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }

            return length;
        }
    }
}
