/*
// Задача 54: Задайте двумерный массив. Напишитепрограмму, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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
    Console.WriteLine("\nМатрица размером 10 на 10:\n");
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

void ArrangeRowMatrix(int[,] matrix)
{
    int max = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int n = 0; n < matrix.GetLength(1); n++)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    max = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = max;
                }
            }

    PrintMatrix(matrix);
}

int[,] matrix = CreateMatrixRandom(10, 10);
ArrangeRowMatrix(matrix);
*/
/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

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
    Console.WriteLine("Матрица размером 10 на 10:\n");
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

void IndexMinSum(int[,] matrix)
{
    int sum = 0;
    int min = 0;
    int index_min = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i, j];
        
        if (i == 0) min = sum;

        if (sum < min)
        {
            min = sum;
            index_min = i;
        }
        sum = 0;
    }
    Console.WriteLine($"\nИндекс строки с минимальной суммой элементов - {index_min}");
}

int[,] matrix = CreateMatrixRandom(5, 5);
IndexMinSum(matrix);
*/
/*
// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10000)
                Console.Write(matrix[i, j] + "  ");
            if (matrix[i, j] < 10)
                Console.Write(matrix[i, j] + "    ");
            else Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void MultiplicationMatrix(int[,] matrix_A, int[,] matrix_B)
{
    int[,] matrix_C = new int[matrix_A.GetLength(0), matrix_B.GetLength(1)];
    int result = 0;

    if (matrix_A.GetLength(0) == matrix_B.GetLength(1))
    {
        for (int i = 0; i < matrix_A.GetLength(0); i++)
            for (int k = 0; k < matrix_B.GetLength(1); k++)
            {
                for (int j = 0; j < matrix_A.GetLength(1); j++)
                    result += matrix_A[i, j] * matrix_B[j, k];

                matrix_C[i, k] = result;
                result = 0;
            }
        Console.WriteLine("\nРезультат умножения матриц А и Б:\n");
        PrintMatrix(matrix_C);
    }
    else
        Console.WriteLine("\nЧисло строк матрицы А НЕ равно числу столбцов матрицы Б. Умножение невозможно.");
}

Console.WriteLine("Матрица А:\n");
int[,] matrix_A = CreateMatrixRandom(3, 2);

Console.WriteLine("\nМатрица Б:\n");
int[,] matrix_B = CreateMatrixRandom(3, 3);

MultiplicationMatrix(matrix_A, matrix_B);
*/
/*
// Задача 60: Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateThreeMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    int sum = 9;

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < z; k++)
                {
                    sum += 1;
                    matrix[i, j, k] = sum;
                }

    PrintMatrix(matrix);
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        Console.WriteLine($"\nz = {k}");
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                if (matrix[i, j, k] < 10)
                    Console.Write(matrix[i, j, k] + "   ");
                else Console.Write(matrix[i, j, k] + "  ");
            }
        Console.WriteLine();
        }
    }
}

CreateThreeMatrix(3, 3, 3);
*/
/*
// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateMatrixRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    int sum = 0;
    int start_column = 0;

    for (int count = 0; count < matrix.GetLength(1) / 2; count++)
    {
        for (int i = count; i < row - count; i++)
        {
            for (int j = start_column; j < column - count; j++)
            {
                matrix[i, j] = sum;
                sum += 1;
            }
            start_column = (column - count) - 1;
        }

        start_column = count + 2;

        for (int i = (row - 1) - count; i > count; i--)
        {
            for (int j = column - start_column; j >= count; j--)
            {
                matrix[i, j] = sum;
                sum += 1;
            }
            start_column = column - count;
        }

        start_column = count + 1;
    }

    PrintMatrix(matrix);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Матрица размером 9 на 9:\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
                Console.Write(matrix[i, j] + "  ");
            else Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

CreateMatrixRandom(10, 10);
*/