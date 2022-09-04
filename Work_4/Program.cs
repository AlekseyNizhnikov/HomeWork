/*
// Задача 25: Напишите цикл, который принимает на вход два числа (А и Б) и возводит число А в натуральную степень Б.
void ArithmeticMetod(int A, int B)
{
    int result = 1;

    for(int i = B; i > 0; i--) result *= A;
    Console.WriteLine($"Число {A} в степени {B} = {result}");
}

Console.Write("Введите число А: ");
int A = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt16(Console.ReadLine());

ArithmeticMetod(A, B);
*/
/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int ReturnNumber(int number)
{
    int result = 0;
    int numb = number;

    while(numb > 0) 
    {
        result += numb % 10;
        numb /= 10;
    }

    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ReturnNumber(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");
*/
/*
// Задача 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
void CreateArray()
{
    int[] array = new int[8];

    for(int i = 0; i < 8; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        int number = Convert.ToInt16(Console.ReadLine());
        array[i] = number;
    }

    PrintArray(array);
}

void PrintArray(int[] array)
{   
    Console.Write("Полученный массив: [");

    for(int i = 0; i < array.Length; i++) 
        Console.Write(" " + array[i]);

    Console.Write("]");
}

CreateArray();
*/