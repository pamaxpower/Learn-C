// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//  456 -> 6
//  782 -> 2
//  918 -> 8

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

// string num = Console.ReadLine();                         // решение через массив
// int last = int.Parse(num[num.Length-1].ToString());
// Console.WriteLine(last);

// int num_dec = num - (num/100)*100;              // убираем первую цифру
// int num_1 = num_dec - (num_dec/10)*10;

int e = num % 10;                            // Находим остаток от деления на 10. Это и будет кол-во единиц
// int d = (num / 10) % 10;                     // Кол-во десятков
// int s = num / 100;                           // Кол-во сотен
Console.WriteLine(e);
