// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int randomNum = new Random().Next(100,1000);
Console.WriteLine("Случайное число: " + randomNum);

// int num1 = (randomNum) / 100;                                                    // 1 способ (для умных)
// int num2 = (randomNum /10) - num1 * 10;
// int num3 = randomNum % 10;
// int a = (randomNum - num1 * 100 - num3) / 10;


// int a = (randomNum - ((randomNum / 100) * 100) - (randomNum % 10)) / 10;         // 2 способ (для ленивых)

Console.WriteLine("Вторая цифра: " + randomNum.ToString()[1]);                      // 3 способ (для гуру)

// Console.WriteLine(a);
