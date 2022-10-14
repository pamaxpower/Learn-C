/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N и с M до N с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"

*/

Console.Clear();

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


//for (int i = M; i <= N; i++) { Console.Write(i); }        // Обычное решение с помощью циклов
// while (M<=N) { Console.Write(M); M++; }


outputRec(M, N);
/*
void outputRec(int m, int n)                    // от M до N - с уменьшения N
{
    n--;
    if (n >= m) outputRec(m, n); ;
    Console.Write(n + 1 + " ");
}
*/

void outputRec(int m, int n)                    // от M до N - с увеличением M
{
    
    if (m <= n) 
    {
        Console.Write(m);
        m++;
        outputRec(m,n);
    }
    else return;
}

//outputRec1N(N);

void outputRec1N(int n)                         // Решение от 1 до N
{
    n--;
    if (n >= 1) outputRec1N(n);
    Console.Write(n+1);
    ;
}

void PrintMN(int m, int n)
{
    Console.Write(m + ", ");
    m++;
    if (m == n)
    {
        Console.Write(n);
        return;
    }
    else PrintMN(m, n);
}
//PrintMN(M,N);

