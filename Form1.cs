using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Labs3
{
    public partial class MainForm : Form
    {
        private MatrixOperations matrixOps;
        private int[,] matrixA;
        private int[,] matrixB;
        private int[,] resultMatrix;
        private int matrixSize;
        private int threadCount;

        public MainForm()
        {
            InitializeComponent();
            numericMatrixSize.Value = 100;
            numericThreadCount.Value = Environment.ProcessorCount;
            matrixSize = (int)numericMatrixSize.Value;
            threadCount = (int)numericThreadCount.Value;

            matrixOps = new MatrixOperations();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            matrixSize = (int)numericMatrixSize.Value;

            matrixA = matrixOps.GenerateRandomMatrix(matrixSize, matrixSize);
            matrixB = matrixOps.GenerateRandomMatrix(matrixSize, matrixSize);

            DisplayMatrix(matrixA, txtMatrixA);
            DisplayMatrix(matrixB, txtMatrixB);

            txtResult.Clear();
            lblTime.Text = "Czas: Nie obliczono...";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int runCount = 3;
            if (matrixA == null || matrixB == null)
            {
                MessageBox.Show("Wygeneruj najpierw macierze");
                return;
            }

            threadCount = (int)numericThreadCount.Value;

            Stopwatch stopwatch = new Stopwatch();
            double elapsedTime = 0;

            for (int run = 0; run < runCount; run++)
            {
                stopwatch.Start();

                resultMatrix = matrixOps.MultiplyMatricesParallel(matrixA, matrixB, threadCount);

                stopwatch.Stop();
                elapsedTime += stopwatch.Elapsed.TotalMilliseconds;
            }

            Stopwatch stopwatch2 = new Stopwatch();
            double elapsedTime2 = 0;

            for (int run = 0; run < runCount; run++)
            {
                stopwatch2.Start();

                matrixOps.MultiplyMatricesThreads(matrixA, matrixB, threadCount);

                stopwatch2.Stop();
                elapsedTime2 += stopwatch2.Elapsed.TotalMilliseconds;
            }
            DisplayMatrix(resultMatrix, txtResult);

            double avgTime = elapsedTime / runCount;
            double avgTime2 = elapsedTime2 / runCount;
            lblTime.Text = ($" Czas Parallel: {avgTime:F2} ms{Environment.NewLine} Czas Threads: {avgTime2:F2} ms");
        }

        private void DisplayMatrix(int[,] matrix, TextBox textBox)
        {
            if (matrix == null) return;

            textBox.Clear();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int displaySize = Math.Min(10, rows);

            for (int i = 0; i < displaySize; i++)
            {
                string line = "";
                for (int j = 0; j < Math.Min(displaySize, cols); j++)
                {
                    line += matrix[i, j].ToString().PadLeft(2) + " ";
                }

                if (cols > displaySize)
                    line += "...";

                textBox.AppendText(line + Environment.NewLine);
            }

            if (rows > displaySize)
                textBox.AppendText("..." + Environment.NewLine);
        }


        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            txtBenchmark.Clear();

            for (int size = 300; size >= 100; size -= 100)
            {
                txtBenchmark.AppendText($"=== Matrix Size: {size}x{size} ===\r\n");

                matrixA = matrixOps.GenerateRandomMatrix(size, size);
                matrixB = matrixOps.GenerateRandomMatrix(size, size);

                txtBenchmark.AppendText("Parallel implementation:\r\n");
                for (int threads = 1; threads <= Environment.ProcessorCount; threads++)
                {
                    const int runCount = 3;
                    double totalTime = 0;

                    for (int run = 0; run < runCount; run++)
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        matrixOps.MultiplyMatricesParallel(matrixA, matrixB, threads);

                        stopwatch.Stop();
                        totalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }

                    double avgTime = totalTime / runCount;
                    txtBenchmark.AppendText($"  Threads: {threads}; Avg Time [ms]: {avgTime:F2}\r\n");
                }

                txtBenchmark.AppendText("Threads implementation:\r\n");
                for (int threads = 1; threads <= Environment.ProcessorCount; threads++)
                {
                    const int runCount = 3;
                    double totalTime = 0;

                    for (int run = 0; run < runCount; run++)
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        matrixOps.MultiplyMatricesThreads(matrixA, matrixB, threads);

                        stopwatch.Stop();
                        totalTime += stopwatch.Elapsed.TotalMilliseconds;
                    }

                    double avgTime = totalTime / runCount;
                    txtBenchmark.AppendText($"  Threads: {threads}; Avg Time [ms]: {avgTime:F2}\r\n");
                }

                txtBenchmark.AppendText("\r\n");
                Application.DoEvents();
            }
        }
    }
}
