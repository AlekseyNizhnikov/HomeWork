/*
// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
int SecondNumber(int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int number= Convert.ToInt16(Console.ReadLine());

int second_number = SecondNumber(number);
Console.WriteLine($"Вторая цифра числа {number} - {second_number}");
*/
/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdNumber(int number)
{   
    int result = number;
    
    if (result / 100 == 0) Console.WriteLine("Третьей цифры нет.");
    else
    {
        while(result / 1000 != 0) result /= 10;
        result %= 10;
        Console.WriteLine($"Третья цифра: {result}");
    }
} 

    Console.Write("Введите любое число: ");
    ThirdNumber(Convert.ToInt32(Console.ReadLine()));
*/
/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Weekend(int numb_day)
{
    if ((numb_day == 6) || (numb_day == 7)) return true;
    else return false;
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt16(Console.ReadLine());

if (Weekend(day)) Console.WriteLine($"{day} день, является выходным.");
else Console.WriteLine($"{day} НЕ является выходным днем.");
*/