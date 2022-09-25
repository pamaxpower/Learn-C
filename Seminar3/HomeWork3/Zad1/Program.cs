/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine());

if (num > 9999 && num < 100000) 
{
    int digit1 = num.ToString()[0];
    int digit2 = num.ToString()[1];
    int digit4 = num.ToString()[3];
    int digit5 = num.ToString()[4];

    if (digit1 == digit5 && digit2 == digit4) 
    {
        Console.WriteLine($"Число {num} является палиндромом");
    } 
    else 
        Console.WriteLine($"Увы, число {num} не палиндромом");
    
} else Console.WriteLine("Вы ввели не пятизначное число. Будьте внимательны!");




