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

#### `GenerateRandomMatrix`
Generuje losową macierz o wymiarach `rows x cols`, wypełnioną liczbami całkowitymi z zakresu `0–9`.

#### `MultiplyMatricesSingleThread`
Klasyczne mnożenie macierzy wykonywane w jednym wątku. Sprawdza się jako punkt odniesienia dla metod równoległych.
![Image](https://github.com/user-attachments/assets/1f719929-6541-4d5b-aeb8-21fc010dcce9)

#### `MultiplyMatricesParallel`
Wykorzystuje `Parallel.For` do równoległego mnożenia macierzy. Liczba wątków może być kontrolowana przez parametr `threadCount`.
![Image](https://github.com/user-attachments/assets/5f3d671e-6a85-464d-872d-19ef861bffdc)

#### `MultiplyMatricesThreads`
Realizuje mnożenie macierzy poprzez ręczne tworzenie i uruchamianie wątków (`Thread`). Działa na podziale zakresów wierszy i synchronizuje wykonanie za pomocą `Join()`.
![Image](https://github.com/user-attachments/assets/14843c4b-7e37-4e27-8725-622de98bb09f)

![Image](https://github.com/user-attachments/assets/45813067-4f8f-449a-a2d9-74ace735f77c)

### Kluczowe cechy
- Obsługa wielu strategii przetwarzania równoległego: zarówno `Parallel.For`, jak i klasyczne wątki (`Thread`).
- Możliwość dostosowania liczby wątków (`threadCount`) w celu testowania wydajności i skalowalności.

## Wyniki
![image](https://github.com/user-attachments/assets/4270daa4-990f-4e13-8367-1f9645dd838f)

![image](https://github.com/user-attachments/assets/c54eef69-4b68-4535-bcf9-155ed36be707)

![image](https://github.com/user-attachments/assets/7338ba04-5347-4f78-ab6c-d8b0afc595f9)

