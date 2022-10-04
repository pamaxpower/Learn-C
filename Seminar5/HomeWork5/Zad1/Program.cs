/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел массива: ");
int LowLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел массива: ");
int PowLimit = Convert.ToInt32(Console.ReadLine());

int[] numbers = FillArray(size, LowLimit, PowLimit);
Console.Write($"Заданный массив: [{String.Join(",",numbers)}]");

int CountEvenElementsArray (int[] array)                    // Количество четных чисел
{
    // int[] newArray = new int [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
            count = count + 1;
    }
    
    return count;
}

Console.WriteLine();
Console.WriteLine($"Число четных чисел в массиве равно: {CountEvenElementsArray(numbers)}");

