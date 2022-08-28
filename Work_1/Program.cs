/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int number_first = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_second = Convert.ToInt16(Console.ReadLine());

int max = number_first;
int min = number_second;

if (min > max)
{
    max = number_second;
    min = number_first;
}

Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
*/
/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("Введите первое число: ");
int number_first = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_second = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_third = Convert.ToInt16(Console.ReadLine());

int max = number_first;

if (number_second > max) max = number_second;
if (number_third > max) max = number_third;

Console.WriteLine($"Максимальное число: {max}");
*/
/*
// Задание 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)
Console.Write("Введите желаемое число: ");
int numb = Convert.ToInt16(Console.ReadLine());
int result = numb % 2;

if (result == 0) Console.WriteLine($"Число {numb} является четным.");
else Console.WriteLine($"Число {numb} НЕ является четным.");
*/
/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.Write("Введите желаемое число: ");
int numb = Convert.ToInt16(Console.ReadLine());
int result = 2;

Console.Write($"Список четных чисел от 0 до {numb}: ");
while(result < numb)
{
    Console.Write(result + " ");
    result += 2;
}
*/