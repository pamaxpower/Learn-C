/* Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();

int[] array = FillArray(5, 1, 10);

Console.WriteLine($"Заданный массива: [{String.Join(",", array)}]");
Console.WriteLine($"Реверс массива: [{String.Join(",", ReverseArray(array))}]");

Console.WriteLine($"Используя встроенный метод, получили: [{String.Join(",", array.Reverse())}]");


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

int[] ReverseArray (int[] arr)                                  // Реверс массива (новый массив начало = старый массив конец)
{
    int[] reverseArray = new int[arr.Length]; 

    for (int i = 0; i < arr.Length; i++)
    {
        reverseArray[i] = arr[arr.Length - 1 - i];
    }
    return reverseArray;
}
/*
int[] ReverseArray(int[] arr)                                  // Реверс массива (новый массив конец = старый массив начало)
{
    int[] reverseArray = new int[arr.Length];

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        reverseArray[arr.Length - 1 - i] = arr[i];
    }
    return reverseArray;
}
*/
