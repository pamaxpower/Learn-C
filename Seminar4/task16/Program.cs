/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSum(int num)
{
    int sum = 0;

    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sum1 = GetSum(num);
Console.WriteLine($"Результат суммы от 1 до {num} = {sum1}");