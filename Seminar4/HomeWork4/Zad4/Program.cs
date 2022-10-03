/* Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 
и найти максимальное значение среди них.
[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
[-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
[-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7
*/

Console.Clear();

void RandomArray (int [] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

int MaxNum (int [] arr)
{
    int max = -11;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > max) max = arr[j];
    }
    return max;
}

int MinNum (int [] arr)
{
    int min = 10;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] < min) min = arr[j];
    }
    return min;
}

int [] numbers = new int [10];

RandomArray(numbers);
Console.Write($"[{String.Join(",",numbers)}]");
Console.WriteLine();
Console.WriteLine($"Максимальное число равно {MaxNum(numbers)}");
Console.WriteLine($"Минимальное число равно {MinNum(numbers)}");
