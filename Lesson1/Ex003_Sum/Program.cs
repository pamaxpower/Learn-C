int numberA = new Random().Next(1, 10);  // ждем случайное число 1,2,3,4,...,9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB; // дополнительный шаг. Можно было пропустить и записать сразу Console.WriteLine(numberA + numberB)
Console.WriteLine(result);   