/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] FillArray (int size, int LowLimit, int PowLimit)                      // Заполнение массива
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



int SumOddElementsArray (int[] array)                               // Сумма нечётных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) 
            sum = sum + array[i];
    }
    
    return sum;
}

Console.WriteLine();

Console.WriteLine($"Сумма нечётных элементов массива: {SumOddElementsArray(numbers)}");
