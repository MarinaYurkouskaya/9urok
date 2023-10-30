//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n=InputInt("Введите число");
int m=1;
int rec(int n, int m)
{
    if (n==m)
    return n;
    else
        Console.Write($"{rec(n, m+1)}, ");
    return m;
}
int InputInt(string N)
{
    Console.Write(N);
    return int.Parse(Console.ReadLine());
}
Console.WriteLine(rec(n,m));
