﻿using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private readonly List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(FillTextBox.Text, out int value))
                {
                    var rnd = new Random();

                    for (int i = 0; i < value; i++)
                    {
                        var item = new SortedItem(rnd.Next(100), items.Count);
                        items.Add(item);
                        panel3.Controls.Add(item.ProgressBar);
                        panel3.Controls.Add(item.Label);
                    }
                }

                FillTextBox.Text = "";
            }
        }
        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            bubble.Sort();
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            e.Item2.SetValue(temp);

            panel3.Refresh();
        }
        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }
    }
}
