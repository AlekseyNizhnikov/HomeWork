/*
// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
void CountingNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    Console.Write("Количество чисел больше 0: ");
    Console.Write(count);
}

int[] CreateArray(int size)
{
    int[] array = new int[size];

    Console.WriteLine($"Введите {size} любых чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i + 1} число ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        array[i] = numbers;
    }
    return array;
}

int[] array = CreateArray(size: 5);
CountingNumbers(array);
*/
/*
// Задача 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравненениями
// y = k1 * x + b1, y = k2 * b1 = 2. Значения k1, k2, b1, b2 задаются пользователем.
void PointSearch(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 3);

    double y = k1 * x + b1;
    y = Math.Round(y, 3);

    Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");
}

Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

PointSearch(k1, b1, k2, b2);
*/