/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

int FindMaxElementArray (int[] array)                                       // Максимальный элемент массива
{
    int MaxElement = LowLimit;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxElement) MaxElement = array[i];
    }
    return MaxElement;
}
int FindMinElementArray (int[] array)                                       // Минимальный элемент массива
{
    int MinElement = PowLimit;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinElement) MinElement = array[i];
    }
    return MinElement;
}


Console.WriteLine();
Console.Write($"Разница между максимальным {FindMaxElementArray(numbers)} и минимальным {FindMinElementArray(numbers)} значениями равно: {FindMaxElementArray(numbers)-FindMinElementArray(numbers)}");


/*
int SumOddElementsArray (int[] array)
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
*/