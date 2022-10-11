// Сортировка массива пузырьком

Console.Clear();

int[] arr = { 6, 4, 5, 8, 9, 6, 3, 4, 7, 0 };
Console.WriteLine($"Массив {String.Join(",", arr)}");

int[] BubbleSortMinMax(int[] arr)                        // Сортировка массива от меньшего к большему
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                int z = arr[i];
                arr[i] = arr[j];
                arr[j] = z;
            }
        }
    }
    return arr;
}

int[] BubbleSortMaxMin(int[] arr)                        // Сортировка массива от большего к меньшему
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int z = arr[i];
                arr[i] = arr[j];
                arr[j] = z;
            }
        }
    }
    return arr;
}

Console.WriteLine($"\nОтсортированный массив {String.Join(",", BubbleSortMinMax(arr))}");
Console.WriteLine($"\nОтсортированный массив {String.Join(",", BubbleSortMaxMin(arr))}");

// Array.Sort(array)               // Сортировка массива от меньшего к большему