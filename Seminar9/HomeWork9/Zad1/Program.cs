/* Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

Console.Clear();

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

EvenNumRec(M,N);
Console.WriteLine();


void EvenNum(int m, int n)
{
    for (int i = m; i < n; i++)
    {
        if (i % 2 == 0) Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void EvenNumRec(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    EvenNumRec(m+1,n);
}
