# MultithreadedMatrixMultiplication

## Struktura projektu
```
Labs3/
├── .gitattributes
├── .gitignore
├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   └── MainForm (klasa formularza)
├── MatrixOperations.cs
│   └── MatrixOperations (klasa pomocnicza do operacji na macierzach)
│       ├── GenerateRandomMatrix
│       ├── MultiplyMatricesSingleThread
│       ├── MultiplyMatricesParallel
│       └── MultiplyMatricesThreads
├── Program.cs
└── README.md
```

## MatrixOperations.cs – Operacje na macierzach z obsługą wielowątkowości

Plik `MatrixOperations.cs` zawiera klasę `MatrixOperations`, która implementuje podstawowe operacje na macierzach, takie jak generowanie danych oraz ich mnożenie z wykorzystaniem różnych podejść do wielowątkowości.

### Dostępne metody

#### `int[,] GenerateRandomMatrix(int rows, int cols)`
Generuje losową macierz o wymiarach `rows x cols`, wypełnioną liczbami całkowitymi z zakresu `0–9`.

#### `int[,] MultiplyMatricesSingleThread(int[,] matrixA, int[,] matrixB)`
Klasyczne mnożenie macierzy wykonywane w jednym wątku. Sprawdza się jako punkt odniesienia dla metod równoległych.

#### `int[,] MultiplyMatricesParallel(int[,] matrixA, int[,] matrixB, int threadCount)`
Wykorzystuje `Parallel.For` do równoległego mnożenia macierzy. Liczba wątków może być kontrolowana przez parametr `threadCount`.

#### `int[,] MultiplyMatricesThreads(int[,] matrixA, int[,] matrixB, int threadCount)`
Realizuje mnożenie macierzy poprzez ręczne tworzenie i uruchamianie wątków (`Thread`). Działa na podziale zakresów wierszy i synchronizuje wykonanie za pomocą `Join()`.

### Kluczowe cechy
- Obsługa wielu strategii przetwarzania równoległego: zarówno `Parallel.For`, jak i klasyczne wątki (`Thread`).
- Możliwość dostosowania liczby wątków (`threadCount`) w celu testowania wydajności i skalowalności.
