/*
Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами
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

double FindSumEvenElementsArray (int[] array)                      // Сумма четных чисел в массиве
{
    double SumEvenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            SumEvenElements = SumEvenElements + array[i];
    }
    return SumEvenElements;
}
double FindSumOddElementsArray (int[] array)                       // Сумма нечетных чисел в массиве
{
    double SumOddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            SumOddElements = SumOddElements + array[i];
    }
    return SumOddElements;
}
int FindCountEvenElementsArray (int[] array)                    // Кол-во четных чисел в массиве
{
    int CountEvenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            CountEvenElements = CountEvenElements + 1;
    }
    return CountEvenElements;
}
int FindCountOddElementsArray (int[] array)                     // Кол-во нечетных чисел в массиве
{
    int CountOddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 1 == 0)
            CountOddElements = CountOddElements + 1;
    }
    return CountOddElements;
}
/*
Console.WriteLine();
Console.WriteLine(FindSumEvenElementsArray (numbers));
Console.WriteLine(FindCountEvenElementsArray (numbers));
Console.WriteLine(FindSumOddElementsArray (numbers));
Console.WriteLine(FindCountOddElementsArray (numbers));
*/
double MidSumEvenElementsArray = FindSumEvenElementsArray (numbers) / FindCountEvenElementsArray (numbers);
double MidSumOddElementsArray = FindSumOddElementsArray (numbers) / FindCountOddElementsArray (numbers);

if (MidSumEvenElementsArray > MidSumOddElementsArray)
    Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] БОЛЬШЕ среднего арифметического нечетных элементов: [{MidSumOddElementsArray}]");
if (MidSumEvenElementsArray < MidSumOddElementsArray)
    Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] МЕНЬШЕ среднего арифметического нечетных элементов: [{MidSumOddElementsArray}]");
if (MidSumEvenElementsArray == MidSumOddElementsArray)
    Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] РАВНО среднему арифметическому нечетных элементов: [{MidSumOddElementsArray}]");
