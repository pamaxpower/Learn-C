/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Clear();

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int [size];
    for ( int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

int[] numbers = FillArray (10,0,100);
Console.Write($"Заданный массив: [{String.Join(",",numbers)}]");
Console.WriteLine();
Console.WriteLine("Введите число от 0 до 100, которое хотите проверить");
int num = Convert.ToInt32(Console.ReadLine());


bool SearchNum (int[] arr, int num1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num1)
        {
            return true;
        }
    }
    return false;
}        
// SearchNum(numbers, num);
Console.WriteLine(SearchNum(numbers, num)?$"Число {num} есть в заданном массиве":$"Числа {num} нет в заданном массиве");

    // if (num == numbers[i]) Console.WriteLine($"Число {num} есть в заданном массиве");
    //else Console.WriteLine($"Числа {num} нет в заданном массиве");


/*
foreach (int element in numbers)
{
    if (element == num) Console.WriteLine($"Число {num} есть в заданном массиве");
}

Console.WriteLine($"Числа {num} нет в заданном массиве");
*/

