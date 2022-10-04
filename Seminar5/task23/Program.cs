/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for (int i=0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

int[] numbers = FillArray (10, 0, 1000);
Console.WriteLine($"Заданный массив: [{String.Join(",",numbers)}]");

int CountElementsArray (int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] > (min - 1) && arr[i] < (max + 1))
        count = count + 1;
    }
    return count;
    
}

Console.WriteLine(CountElementsArray(numbers, 10, 99));
/*
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10 && numbers[i] < 99)
        count = count + 1;
}

Console.WriteLine(count);
*/

