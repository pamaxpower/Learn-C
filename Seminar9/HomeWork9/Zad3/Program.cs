/* Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

M = 28; N = 7 -> 7
*/

Console.Clear();

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Наибольший общий делитель чисел {M} и {N} равен {GreatestCommonDivisitor(M, N)}");

int GreatestCommonDivisitor(int a, int b)
{
    int gcd = 0;
    if (a < 0) return gcd = GreatestCommonDivisitor(-a, b);     // Если числа отрицательные
    if (b < 0) return gcd = GreatestCommonDivisitor(a, -b);
    if (a == 0) return gcd = b;                                 // ноль делится на любое число
    if (b == 0) return gcd = a;
    if (a == b) return gcd = a;
    if (a == 1 && b == 1) return gcd = 1;                       // единица имеет только один делитель: 1
    if (a % b > 0)                                              // Остаток от деления больше 0
    {
        return gcd = GreatestCommonDivisitor(b, a % b);
    }
    else return b;
}



/*int gcd06(int a, int b) 
{
    if (a == 0)
        return b;
    if (b == 0)
    if (a == b)
        return a;
    if (a == 1 || b == 1)
        return 1;
    if (a % 2 == 0 && b % 2 == 0)
        return 2 * gcd06(a / 2, b / 2);
    if (a % 2 == 0L && b % 2 != 0)
        return gcd06(a / 2, b);
    if (a % 2 != 0 && b % 2 == 0)
        return gcd06(a, b / 2);
    if (a < b)
        return gcd06((b - a) / 2, a);
    else
        return gcd06((a - b) / 2, b);
}
*/