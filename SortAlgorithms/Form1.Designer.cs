using System;

namespace SortAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.CocktailSortBtn = new System.Windows.Forms.Button();
            this.InsertSortBtn = new System.Windows.Forms.Button();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LSDRedixBtn = new System.Windows.Forms.Button();
            this.MSDRedixBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(303, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(15, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(285, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 59);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(303, 24);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 20);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(15, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(285, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(387, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 124);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BubbleSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 130);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(75, 23);
            this.BubbleSortBtn.TabIndex = 6;
            this.BubbleSortBtn.Text = "BubbleSort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 156);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(40, 13);
            this.TimeLbl.TabIndex = 7;
            this.TimeLbl.Text = "Время";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 181);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(98, 13);
            this.CompareLbl.TabIndex = 8;
            this.CompareLbl.Text = "Кол-во сравнений";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(12, 206);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(88, 13);
            this.SwopLbl.TabIndex = 9;
            this.SwopLbl.Text = "Кол-во обменов";
            // 
            // CocktailSortBtn
            // 
            this.CocktailSortBtn.Location = new System.Drawing.Point(93, 130);
            this.CocktailSortBtn.Name = "CocktailSortBtn";
            this.CocktailSortBtn.Size = new System.Drawing.Size(75, 23);
            this.CocktailSortBtn.TabIndex = 10;
            this.CocktailSortBtn.Text = "CocktailSort";
            this.CocktailSortBtn.UseVisualStyleBackColor = true;
            this.CocktailSortBtn.Click += new System.EventHandler(this.CocktailSortBtn_Click);
            // 
            // InsertSortBtn
            // 
            this.InsertSortBtn.Location = new System.Drawing.Point(174, 130);
            this.InsertSortBtn.Name = "InsertSortBtn";
            this.InsertSortBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertSortBtn.TabIndex = 11;
            this.InsertSortBtn.Text = "InsertSort";
            this.InsertSortBtn.UseVisualStyleBackColor = true;
            this.InsertSortBtn.Click += new System.EventHandler(this.InsertSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(255, 130);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(75, 23);
            this.ShellSortBtn.TabIndex = 12;
            this.ShellSortBtn.Text = "ShellSort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(336, 130);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(84, 23);
            this.SelectionSortBtn.TabIndex = 13;
            this.SelectionSortBtn.Text = "SelectionSort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(426, 130);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(75, 23);
            this.HeapSortBtn.TabIndex = 14;
            this.HeapSortBtn.Text = "HeapSort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(507, 130);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.GnomeSortBtn.TabIndex = 15;
            this.GnomeSortBtn.Text = "GnomeSort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(588, 130);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.TreeSortBtn.TabIndex = 16;
            this.TreeSortBtn.Text = "TreeSort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LSDRedixBtn
            // 
            this.LSDRedixBtn.Location = new System.Drawing.Point(669, 130);
            this.LSDRedixBtn.Name = "LSDRedixBtn";
            this.LSDRedixBtn.Size = new System.Drawing.Size(86, 23);
            this.LSDRedixBtn.TabIndex = 17;
            this.LSDRedixBtn.Text = "LSDRedixSort";
            this.LSDRedixBtn.UseVisualStyleBackColor = true;
            this.LSDRedixBtn.Click += new System.EventHandler(this.LSDRedixBtn_Click);
            // 
            // MSDRedixBtn
            // 
            this.MSDRedixBtn.Location = new System.Drawing.Point(761, 130);
            this.MSDRedixBtn.Name = "MSDRedixBtn";
            this.MSDRedixBtn.Size = new System.Drawing.Size(89, 23);
            this.MSDRedixBtn.TabIndex = 18;
            this.MSDRedixBtn.Text = "MSDRedixSort";
            this.MSDRedixBtn.UseVisualStyleBackColor = true;
            this.MSDRedixBtn.Click += new System.EventHandler(this.MSDRedixBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(856, 130);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.MergeSortBtn.TabIndex = 19;
            this.MergeSortBtn.Text = "MergeSort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.Location = new System.Drawing.Point(937, 130);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(75, 23);
            this.QuickSortBtn.TabIndex = 20;
            this.QuickSortBtn.Text = "QuickSort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 257);
            this.Controls.Add(this.QuickSortBtn);
            this.Controls.Add(this.MergeSortBtn);
            this.Controls.Add(this.MSDRedixBtn);
            this.Controls.Add(this.LSDRedixBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.InsertSortBtn);
            this.Controls.Add(this.CocktailSortBtn);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(12, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Button CocktailSortBtn;
        private System.Windows.Forms.Button InsertSortBtn;
        private System.Windows.Forms.Button ShellSortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LSDRedixBtn;
        private System.Windows.Forms.Button MSDRedixBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button QuickSortBtn;
    }
}

