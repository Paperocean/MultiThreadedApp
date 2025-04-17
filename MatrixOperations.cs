using System;
using System.Threading;
using System.Threading.Tasks;

namespace Labs3
{
    public class MatrixOperations
    {
        private Random random;

        public MatrixOperations()
        {
            random = new Random();
        }

        /// <summary>
        /// Generowanie losowej macierzy o podanych wymiarach.
        /// </summary>
        public int[,] GenerateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Mnożenie dwóch macierzy w jednym wątku.
        /// </summary>
        public int[,] MultiplyMatricesSingleThread(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);
            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Mnożenie dwóch macierzy z użyciem Parallel.
        /// </summary>
        public int[,] MultiplyMatricesParallel(int[,] matrixA, int[,] matrixB, int threadCount)
        {
            if (threadCount <= 1)
            {
                return MultiplyMatricesSingleThread(matrixA, matrixB);
            }

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);
            int[,] result = new int[rowsA, colsB];

            ParallelOptions options = new ParallelOptions
            {
                // Ustawienie liczby wątków
                MaxDegreeOfParallelism = threadCount
            };

            int[] threadUsed = new int[Environment.ProcessorCount];

            Parallel.For(0, rowsA, options, i =>
            {
                // Zliczanie użycia wątków
                Interlocked.Increment(ref threadUsed[Thread.CurrentThread.ManagedThreadId % Environment.ProcessorCount]);

                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            });

            return result;
        }

        /// <summary>
        /// Mnożenie dwóch macierzy z użyciem Thread.
        /// </summary>
        public int[,] MultiplyMatricesThreads(int[,] matrixA, int[,] matrixB, int threadCount)
        {
            if (threadCount <= 1)
            {
                return MultiplyMatricesSingleThread(matrixA, matrixB);
            }

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);
            int[,] result = new int[rowsA, colsB];

            Thread[] threads = new Thread[threadCount];

            // Zliczanie użycia wątków na wierszach
            int rowsPerThread = rowsA / threadCount;
            int remainingRows = rowsA % threadCount;

            for (int t = 0; t < threadCount; t++)
            {
                // Obliczanie zakresu wierszy dla każdego wątku
                int startRow = t * rowsPerThread + Math.Min(t, remainingRows);
                int endRow = startRow + rowsPerThread + (t < remainingRows ? 1 : 0);
                int threadIndex = t;

                threads[t] = new Thread(() =>
                {
                    for (int i = startRow; i < endRow; i++)
                    {
                        for (int j = 0; j < colsB; j++)
                        {
                            result[i, j] = 0;
                            for (int k = 0; k < colsA; k++)
                            {
                                result[i, j] += matrixA[i, k] * matrixB[k, j];
                            }
                        }
                    }
                });

                threads[t].Start();
            }

            // Czekanie na zakończenie wszystkich wątków
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            return result;
        }
    }
}