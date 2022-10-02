/*
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNaturalNumbers(int M, int N)
{
    if(M <= 0) PrintNaturalNumbers(M + 1, N);
    else
    {
        Console.Write(M + " ");
        if(M < N) PrintNaturalNumbers(M + 1, N);
    }
}

void FilterNumbers(int M, int N)
{
    if(N > 0 || M > 0) 
    {
        if(N > M) PrintNaturalNumbers(M, N);
        if(M > N) PrintNaturalNumbers(N, M);
    }
    else Console.WriteLine("В указанном диапазоне нет натуральных чисел.");
}

FilterNumbers(10, -10);
*/
/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
double PrintSumNumbers(int M, int N)
{
    if (M <= 0) return PrintSumNumbers(M = 1, N) + M;
    else
    {
        if (M < N) return PrintSumNumbers(M + 1, N) + (M + 1);
        else return 0;
    }
}

double FilterNumbers(int M, int N)
{
    if (N > 0 || M > 0)
    {
        if (N > M) return PrintSumNumbers(M, N);
        if (M > N) return PrintSumNumbers(N, M);
        else return 0;
    }
    else return 0;
}

Console.WriteLine(FilterNumbers(3, 0));
*/
/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermanMethod(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanMethod(m - 1, 1);
    if (m > 0 && n > 0) return AckermanMethod(m - 1, AckermanMethod(m, n - 1));
    return AckermanMethod(m, n);
}

Console.WriteLine(AckermanMethod(m:3, n:2));
*/