// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSumm (int a, int b)
{
    if (a == b) return b;
    else
    {
        return a + FindSumm(a+1, b);
    }
}

Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
int summNat = FindSumm(firstNum, secondNum);
Console.WriteLine($"Сумма натуральных чисел равна {summNat}");