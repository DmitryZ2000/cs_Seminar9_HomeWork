// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements(int m, int n)
{
    if (m == n) return n;
    return m + SumElements(m+1,n);
}

Console.Write("Введите начальное любое целое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumElements(m, n);
Console.WriteLine($"Сумма элементов = {sum}");