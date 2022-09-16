// Напишите программу, которая на вход принимает число и выдает его квадрат
// (Число умноженное на само себя)
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();

Console.Write("Введите число: "); 

int number = Convert.ToInt32(Console.ReadLine());

int sqr = number * number;
Console.Write("Квадрат числа равен: ");  // Console.WriteLine($"Квадрат числа равен: {sqr}");
Console.Write(sqr);

// Сonsole.Write("Квадрат числа равен: " + Math.Pow(number, 2)); - или это делается одной командой, тогда исключаются строки 13,14,15
