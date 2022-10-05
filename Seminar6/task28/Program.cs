// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] array = FillArray (5,1,10);
Console.WriteLine($"Заданный массив : [{String.Join(",",array)}]");
Console.WriteLine($"Копия массива : [{String.Join(",",CopyArray(array))}]");

int[] FillArray(int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for
    (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}
