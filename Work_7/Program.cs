/*
// Задача 47: Задайте двумерный массив размером m на n, заполненный случайныи вещественными числами
double[,] CreateMatrixRandom(int n, int m)
{
    double[,] matrix = new double[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            matrix[i, j] = new Random().NextDouble() * 10;

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("\nИтоговая матрица:");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0:f2} ", matrix[i, j]);
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt16(Console.ReadLine());

PrintMatrix(CreateMatrixRandom(n, m));
*/
/*
// Задача 50: Напишите программу, которая на вход рпинимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
int[,] CreateMatrixRandom(int n, int m)
{
    int[,] matrix = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            matrix[i, j] = new Random().Next(0, 100);

    PrintMatrix(matrix);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("\nМатрица размером 10 на 10:");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
                Console.Write(matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void ElementsMatrix(int[,] matrix, int column, int row, int m, int n)
{
    if (column <= m && row <= n)
        Console.WriteLine($"\nИскомый элемент массива: {matrix[column, row]}");
    else
        Console.WriteLine($"\nЭлемента с индексами m = {column} и n = {row} в данном массиве не существует.");
}

Console.Write("Введите строку искомого элемента: ");
int column = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите столбец искомого элемента: ");
int row = Convert.ToInt16(Console.ReadLine());

int[,] matrix = CreateMatrixRandom(n: 10, m: 10);
ElementsMatrix(matrix, column, row, m: 10, n: 10);
*/
/*
// Задача 52: задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
int[,] CreateMatrixRandom(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = new Random().Next(0, 100);

    PrintMatrix(matrix);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("\nМатрица размером 10 на 10:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
                Console.Write(matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void SearchSumMiddle(int[,] matrix)
{
    double sum = 0.0;
    double[] result = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            sum += matrix[i, j];
        result[j] = sum / matrix.GetLength(1);
        sum = 0;
    }
    PrintArray(result);
}

void PrintArray(double[] array)
{
    Console.WriteLine("\nСреднее арифметическое каждого столбца матрицы:");
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"Столбец {i}: " + "{0:f2} ", array[i]);
}

int[,] matrix = CreateMatrixRandom(m: 5, n: 5);
SearchSumMiddle(matrix);
*/