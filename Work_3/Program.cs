/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrome(int number)
{   
    int numb = number;
    int result = 0;
    int remains = 0;

    while (numb > 0)
    {
        remains = numb % 10;
        result = (result * 10) + remains;
        numb /= 10;
    }

    if (result == number) Console.WriteLine($"Число {number} является палиндромом.");
    else Console.WriteLine($"Число {number} НЕ является палиндромом.");
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
*/
/*
// Задача 21: Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в трехмерном пространстве.
void LengthPoint(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
{
    int dx = (int)Math.Pow((x_2 - x_1), 2);
    int dy = (int)Math.Pow((y_2 - y_1), 2);
    int dz = (int)Math.Pow((z_2 - z_1), 2);

    double result = (double)Math.Sqrt(dx + dy + dz);

    Console.WriteLine($"Расстояние между точками равно: {(double)Math.Round(result, 2)} у.е..");
}

Console.Write("Введите координату X первой точки: ");
int x_1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y_1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z_1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int x_2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y_2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z_2 = Convert.ToInt16(Console.ReadLine());

LengthPoint(x_1, y_1, z_1, x_2, y_2, z_2);
*/
/*
// Задача 23: Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N
void SquareNumb(int number)
{
    int count = 1;
    int result = 0;
    
    Console.Write($"Диапазон квадратов чисел от 1 до {number}:");
    
    while (count <= number)
    {
        result = (int)Math.Pow(count, 3);
        Console.Write($" {result}");
        count += 1;
    }
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt16(Console.ReadLine());

SquareNumb(number);
*/