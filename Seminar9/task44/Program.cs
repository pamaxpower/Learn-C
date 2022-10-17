/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Clear();

Console.WriteLine("Введите число M: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
double B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ExponentiationRec(A, B));

double ExponentiationRec(double n, double pow)
{
    if (pow == 0) return 1;
    if (pow < 0) return 1 / (n * ExponentiationRec(n, (-pow) - 1));
    return n * ExponentiationRec(n, pow - 1);
}