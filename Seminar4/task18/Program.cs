/* Задача 28: Напишите программу, которая принимает на вход число N и M и выдаёт произведение чисел от M до N.
2,4 -> 24
1,5 -> 120
*/

Console.Clear();

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetMult (int a, int b)
{
    int mult = 1;
    while (a <= b)                  // либо через for (i = a; a <= b; a++)
    {
        mult = mult * a;
        a++;
    }
    return mult;
}
Console.WriteLine($"Произведение чисел от {M} до {N} равно {GetMult(M,N)}");