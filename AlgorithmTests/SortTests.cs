﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        readonly Random rnd = new Random();
        readonly List<int> Items = new List<int>();
        readonly List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // act
            bubble.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            // arrange
            var cocktail = new CoctailSort<int>();
            cocktail.Items.AddRange(Items);

            // act
            cocktail.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // act
            insert.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // act
            shell.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            // act
            bases.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            // arrange
            var tree = new TreeSort<int>();
            tree.Items.AddRange(Items);

            // act
            tree.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // arrange
            var heap = new HeapSort<int>();
            heap.Items.AddRange(Items);

            // act
            heap.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }
    }
}