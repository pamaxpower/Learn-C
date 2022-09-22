// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int randomNum = new Random().Next(1,10000);
Console.WriteLine(randomNum);
int digit3 = -1;

while (randomNum > 99)
{
    digit3 = randomNum % 10;
    randomNum = randomNum / 10;
}
if (digit3 >= 0)
{
    Console.WriteLine(digit3);
}
else
    Console.WriteLine("такой цифры нет");


// if (randomNum / 100 != 0)
// {
//    Console.WriteLine("Третья цифра: " + randomNum.ToString()[2]);
// }
// else Console.WriteLine("третьей цифры нет");








