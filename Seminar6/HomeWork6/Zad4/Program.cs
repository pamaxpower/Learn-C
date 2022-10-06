/*
Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить
существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.
[1,2,3,3] -> [1,2,3,4]
*/
Console.Clear();

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(M, min, max);

// int[] array = FillArray(10, 1, 3);

Console.WriteLine($"Заданный массив: {String.Join(",",array)} ");
ChangeElementsArray(array);

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

void ChangeElementsArray(int[] arr)
{
    int n = max + 1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            arr[i + 1] = n;
            n = n + 1;
        }
    }
    Console.WriteLine($"Измененный массив: {String.Join(",", arr)} ");
}
