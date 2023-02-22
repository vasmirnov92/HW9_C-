﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int n)
{

    if (n==1) return n.ToString();
    else
    {
        return n.ToString() + ", " + PrintNumbers(n-1);
    }    
}

Console.Clear();
Console.Write("Введите число: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(max));