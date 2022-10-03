/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.WriteLine("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double B = Convert.ToInt32(Console.ReadLine());

if (A == 0 && B < 0)
{
    Console.WriteLine("Деление на 0");
}
else
{
    //double exp = Math.Pow(A, B);

    double exp = 1;
    for (int i = 1; i <= B; i++)
        {
            exp =  exp * A;
        }
    Console.WriteLine($"Если число {A} возвести в степень {B}, то получится {Convert.ToInt32(exp)}");
}