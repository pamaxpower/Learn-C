/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
Console.WriteLine($"Сумма цифр в числе {num} равно {SumDigitRec(num)}");
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {num} равно {SumDigitRec2(num)}");

int SumDigitRec(int n)
{
    if (n != 0)
    {
        sum = sum + n % 10;
        return SumDigitRec(n / 10);
    }
    return sum;
}

int SumDigitRec2(int n)
{
    if (n == 0) return 0;
    return (n%10 + SumDigitRec2(n / 10));
}




