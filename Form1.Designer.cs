namespace Labs3
{
    partial class MainForm
    {
        private System.Windows.Forms.NumericUpDown numericMatrixSize;
        private System.Windows.Forms.NumericUpDown numericThreadCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.TextBox txtBenchmark;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            numericMatrixSize = new NumericUpDown();
            numericThreadCount = new NumericUpDown();
            btnGenerate = new Button();
            btnCalculate = new Button();
            txtMatrixA = new TextBox();
            txtMatrixB = new TextBox();
            txtResult = new TextBox();
            lblTime = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBenchmark = new Button();
            txtBenchmark = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericMatrixSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericThreadCount).BeginInit();
            SuspendLayout();
            // 
            // numericMatrixSize
            // 
            numericMatrixSize.Location = new Point(765, 28);
            numericMatrixSize.Margin = new Padding(4, 5, 4, 5);
            numericMatrixSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericMatrixSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericMatrixSize.Name = "numericMatrixSize";
            numericMatrixSize.Size = new Size(107, 27);
            numericMatrixSize.TabIndex = 0;
            numericMatrixSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericThreadCount
            // 
            numericThreadCount.Location = new Point(765, 74);
            numericThreadCount.Margin = new Padding(4, 5, 4, 5);
            numericThreadCount.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numericThreadCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericThreadCount.Name = "numericThreadCount";
            numericThreadCount.Size = new Size(107, 27);
            numericThreadCount.TabIndex = 1;
            numericThreadCount.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(712, 131);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 35);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Wygeneruj Macierze";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(712, 176);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 35);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtMatrixA
            // 
            txtMatrixA.Font = new Font("Courier New", 8.25F);
            txtMatrixA.Location = new Point(20, 56);
            txtMatrixA.Margin = new Padding(4, 5, 4, 5);
            txtMatrixA.Multiline = true;
            txtMatrixA.Name = "txtMatrixA";
            txtMatrixA.ReadOnly = true;
            txtMatrixA.ScrollBars = ScrollBars.Both;
            txtMatrixA.Size = new Size(265, 250);
            txtMatrixA.TabIndex = 5;
            // 
            // txtMatrixB
            // 
            txtMatrixB.Font = new Font("Courier New", 8.25F);
            txtMatrixB.Location = new Point(317, 56);
            txtMatrixB.Margin = new Padding(4, 5, 4, 5);
            txtMatrixB.Multiline = true;
            txtMatrixB.Name = "txtMatrixB";
            txtMatrixB.ReadOnly = true;
            txtMatrixB.ScrollBars = ScrollBars.Both;
            txtMatrixB.Size = new Size(265, 250);
            txtMatrixB.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Courier New", 8.25F);
            txtResult.Location = new Point(20, 372);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(265, 250);
            txtResult.TabIndex = 7;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(712, 229);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(151, 20);
            lblTime.TabIndex = 9;
            lblTime.Text = "Czas: Nie obliczono....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 10;
            label1.Text = "Wielkość macierzy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(618, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 11;
            label2.Text = "Liczba wątków:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 12;
            label3.Text = "Macierz A:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "Macierz B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 347);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 14;
            label5.Text = "Wynik:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 445);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 15;
            label6.Text = "Benchmark:";
            // 
            // btnBenchmark
            // 
            btnBenchmark.Location = new Point(317, 405);
            btnBenchmark.Margin = new Padding(4, 5, 4, 5);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(160, 35);
            btnBenchmark.TabIndex = 4;
            btnBenchmark.Text = "Uruchom Benchmark";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // txtBenchmark
            // 
            txtBenchmark.Font = new Font("Courier New", 8.25F);
            txtBenchmark.Location = new Point(317, 470);
            txtBenchmark.Margin = new Padding(4, 5, 4, 5);
            txtBenchmark.Multiline = true;
            txtBenchmark.Name = "txtBenchmark";
            txtBenchmark.ReadOnly = true;
            txtBenchmark.ScrollBars = ScrollBars.Both;
            txtBenchmark.Size = new Size(555, 152);
            txtBenchmark.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 692);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTime);
            Controls.Add(txtBenchmark);
            Controls.Add(txtResult);
            Controls.Add(txtMatrixB);
            Controls.Add(txtMatrixA);
            Controls.Add(btnBenchmark);
            Controls.Add(btnCalculate);
            Controls.Add(btnGenerate);
            Controls.Add(numericThreadCount);
            Controls.Add(numericMatrixSize);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "ParrarelApp";
            ((System.ComponentModel.ISupportInitialize)numericMatrixSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericThreadCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
