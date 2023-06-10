/*
Задать значение N. Написать программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> " 8, 7, 6, 5, 4, 3, 2, 1"
*/

string Rec(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return (start + Rec(start - 1, end));
}
Console.WriteLine(Rec(5, 1));



