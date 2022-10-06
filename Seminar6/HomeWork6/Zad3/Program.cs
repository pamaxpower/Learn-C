/* Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и 
сдвинуть элементы массива влево, или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо
*/

Console.Clear();

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(M, min, max);

// int[] array = FillArray(5, 0, 10);

Console.WriteLine($"Заданный массив: {String.Join(",",array)} ");
Console.WriteLine($"Сдвиг влево: {String.Join(",",LeftShiftArray(array))} ");
Console.WriteLine($"Сдвиг влево: {String.Join(",",RigthShiftArray(array))} ");

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

int[] LeftShiftArray (int[] arr)
{
    int[] leftShift = new int[arr.Length];
    for (int i = 0; i < arr.Length-1; i++)
    {
        leftShift[i] = arr[i+1];
    }
    leftShift[arr.Length-1] = arr[0];

    return leftShift;
}

int[] RigthShiftArray (int[] arr)
{
    int[] rigthShift = new int[arr.Length];
    for (int i = 1; i < arr.Length; i++)
    {
        rigthShift[i] = arr[i-1];
    }
    rigthShift[0] = arr[arr.Length-1];

    return rigthShift;
}