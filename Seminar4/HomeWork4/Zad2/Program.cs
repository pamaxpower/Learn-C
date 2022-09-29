/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

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

Console.WriteLine($"Сумма цифр в числе {num} равно {SumDigit(num)}");

