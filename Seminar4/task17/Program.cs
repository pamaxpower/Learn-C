/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void num_count(int num1)
{
    int count = 0;
    while (num1 != 0)
    {
        num1 = num1 / 10;                   // работает только с числом до 10 знаков
        count++;
    }
    Console.WriteLine(count);
}

num_count(num);