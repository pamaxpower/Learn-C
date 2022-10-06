/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Clear();

/*
// 1 способ: через рандромный массив

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(M, min, max);
Console.WriteLine($"Заданный массив: {String.Join(",",array)} ");
Console.WriteLine($"Количество чисел больше 0 равно: {CountPositiveNumbers(array)}");


int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}
int CountPositiveNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
*/

// 2 способ: ввод чисел с клавиатуры, через пробел

Console.WriteLine("Введите числа через пробел: ");
string[] arr= Console.ReadLine().Split();                           // Считывает строку и добавляет значение в массив
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Convert.ToInt32(arr[i]) > 0) count++;
    }
Console.WriteLine($"Количество чисел больше 0 равно: {count}");
