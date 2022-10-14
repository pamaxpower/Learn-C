/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Rec (int a)
{
    int sum = 0;
    if (a != 0)
    {

    }
    
    
    
    return sum;
    else a=a/10;
    sum = sum +a;
    return sum;
}
/*
int SumDigit (int number)
{
    int sum = 0;
    while (number != 0)
    {
        int a = number - (number / 10)*10;
        number = number / 10;
        sum = sum + a;
    }
    return sum;
} 
*/
Console.WriteLine($"Сумма цифр в числе {num} равно {Rec(num)}");