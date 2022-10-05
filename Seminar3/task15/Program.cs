/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= num)
{
    double square = Math.Pow(count, 2);

    Console.Write(square + " ");
    count++;
}

// for (int i = 1; i <= num; i++)                           // через цикл for
//     Console.Write(Math.Pow(i, 2) + " ");



// если N < 0:
// while (num < count)
// {
//     double squar = Math.Pow(count, 2);

//     Console.Write($"{squar}, ");
//     count--;
// }
