// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа (41:24)
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.WriteLine("Средняя цифра: " + randomNum.ToString()[1]); - конвертирует случайное число в строку. В [] индекс элемента

Console.Clear();

int randomNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {randomNum}");

int mem = randomNum / 100 * 10 + randomNum % 10;

Console.WriteLine(mem);