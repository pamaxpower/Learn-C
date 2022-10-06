/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

Console.WriteLine("Введите число N: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < count; i++)
{
    array[i] = array[i-1] + array[i-2];
}
Console.Write($"Первые {count} числа Фибоначчи: {String.Join(" ",array)}");
