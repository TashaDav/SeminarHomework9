/*
Задать значение N. Написать программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> " 8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
string Rec(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return (start + Rec(start - 1, end));
}
Console.WriteLine(Rec(8, 1));
*/

  Console.Write("Введите число N: ");
  int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число М: ");
  int m = Convert.ToInt32(Console.ReadLine());

void Recurs (int n, int m)
{
    if (n >= m)
    {
        Console.WriteLine(n);
        n = n - 1;
        Recurs (n, m);
    }
    return;
}
Recurs (n, m);






