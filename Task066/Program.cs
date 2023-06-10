/*
Задать значения M и N. Написать программу, которая найдет сумму
натуральных элементов в промежутке от М до N.
М = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum(int m, int n)
{
if (m==n)
return n;
else return m + sum(m + 1, n);
}
Console.Write($"Сумма элементов от M до N:  {sum(m,n)}");