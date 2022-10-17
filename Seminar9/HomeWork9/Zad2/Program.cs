/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

Console.Clear();

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"Сумма числе от {M} до {N} равна {SumNumber(M,N)}" );
Console.WriteLine($"Сумма числе от {M} до {N} равна {SumNumberRec(M,N)}" );


int SumNumber(int a, int b)
{
    int sumNumber = 0;
    for (int i = a; a <= b; a++)
    {
        sumNumber = sumNumber + a;
    }
    return sumNumber;
}


int SumNumberRec (int a, int b)
{
    int sum = 0;
    if (a <= b) 
    {
        sum = a + SumNumberRec(a+1,b);
    }
    return sum;
}
