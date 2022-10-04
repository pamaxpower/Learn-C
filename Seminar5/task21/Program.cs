// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] FillArray (int size, int min, int max)                        
{
    int[] filledArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
}

int[] numbers = FillArray(5, -10, 10);
Console.Write($"Заданный массив: [{String.Join(",",numbers)}]");
Console.WriteLine();

int[] ChangeArray (int [] array)
{
    int[] changeArray = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        changeArray[index] = array[index] * (-1);                            // Перевод числа на противоположное
    }
    return changeArray;
}

int[] chArr = ChangeArray(numbers);
Console.Write($"Измененный массив: [{String.Join(",",chArr)}]");