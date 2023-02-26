// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9



int Ackerman (int a, int b)
{
    if (a == 0) return (b+1);
    else if (b == 0) return (Ackerman(a-1, 1));
    else return Ackerman(a-1, Ackerman(a, b-1));
}

Console.Clear();
Console.WriteLine("Для вычисления функции Аккермана введите 2 неотрицаетльных числа.");
Console.WriteLine("Введите первое число m : ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число n : ");
int secondNum = int.Parse(Console.ReadLine());
int ack = Ackerman(firstNum, secondNum);
Console.WriteLine($"A(m, n = {ack})");