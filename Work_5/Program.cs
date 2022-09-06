/*
// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. 
//Напишите программу, которая покажет количество четных чисел в массиве.
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    PrintArray(array);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: [");

    for(int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");

    Console.Write("]");
}

int EvenNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    return count;
}

int[] array = RandomArray(size: 10, minValue: 100, maxValue: 999);
Console.Write($"\nКоличество четных чисел в массиве: {EvenNumbers(array)}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    PrintArray(array);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: [");

    for(int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");

    Console.Write("]");
}

int SumUnevenNumbers(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2) sum += array[i];

    return sum;
}

int[] array = RandomArray(size: 10, minValue: 0, maxValue: 100);
Console.Write($"\nСумма чисел стоящих на нечетных позициях: {SumUnevenNumbers(array)}");
*/
/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] RandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    double part = 0.0;
    int intrger = 0;

    for(int i = 0; i < size; i++)
    {
        part = new Random().NextDouble();
        intrger = new Random().Next(minValue, maxValue);
        array[i] = Math.Round(part + intrger, 3);
    }

    PrintArray(array);
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Массив: [");

    for(int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");

    Console.Write("]");
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    result = max - min;
    return result;
}

double[] array = RandomDoubleArray(size: 10, minValue: 0, maxValue: 100);
Console.Write($"\nРазница между max и min: {Difference(array)}");
*/