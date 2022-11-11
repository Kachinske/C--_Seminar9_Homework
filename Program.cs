// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число и я выведу все натуральные числа в промежутке от числа до 1");
int NumTask64 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(PrintNumbersReversed(NumTask64,1));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int FirstNumTask66 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int SecondNumTask66 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов между числами {FirstNumTask66} и {SecondNumTask66} равна: {SumBetweenNumbers(FirstNumTask66,SecondNumTask66)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число:");
int FirstNumTask68 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int SecondNumTask68 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Вычисление по функции Аккермана равно: {Ackerman(FirstNumTask68,SecondNumTask68)}");


// Methods

int Ackerman (int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackerman(n-1, 1);
    if (n > 0 && m > 0) return Ackerman(n - 1, Ackerman(n, m - 1));
    return Ackerman(n,m);
}

int SumBetweenNumbers(int start, int finish)
{
    if (start == finish) return finish;
    if (start > finish) return finish + SumBetweenNumbers(start, finish + 1);
    return start + SumBetweenNumbers(start + 1, finish);
}

String PrintNumbersReversed(int start, int finish)
{
    if (start == finish) return start.ToString();
    return (start + " " + PrintNumbersReversed(start - 1, finish));
}