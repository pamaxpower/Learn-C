// Домашнее задание №5

Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4,5), решение которой вы хотите посмотреть");
int zad = Convert.ToInt32(Console.ReadLine());

int[] FillArray (int size, int LowLimit, int PowLimit)                      // Заполнение массива
{
    int[] filledArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}
int CountEvenElementsArray (int[] array)                                    // Количество четных чисел
{
    // int[] newArray = new int [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
            count = count + 1;
    }
    
    return count;
}
int SumOddElementsArray (int[] array)                                       // Сумма нечётных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) 
            sum = sum + array[i];
    }
    
    return sum;
}
int FindMaxElementArray (int[] array)                                       // Максимальный элемент массива
{
    int MaxElement = -10000;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxElement) MaxElement = array[i];
    }
    return MaxElement;
}
int FindMinElementArray (int[] array)                                       // Минимальный элемент массива
{
    int MinElement = 10000;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinElement) MinElement = array[i];
    }
    return MinElement;
}
double FindSumEvenElementsArray (int[] array)                               // Сумма четных чисел в массиве
{
    double SumEvenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            SumEvenElements = SumEvenElements + array[i];
    }
    return SumEvenElements;
}
double FindSumOddElementsArray (int[] array)                                // Сумма нечетных чисел в массиве
{
    double SumOddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            SumOddElements = SumOddElements + array[i];
    }
    return SumOddElements;
}
int FindCountEvenElementsArray (int[] array)                                // Кол-во четных чисел в массиве
{
    int CountEvenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            CountEvenElements = CountEvenElements + 1;
    }
    return CountEvenElements;
}
int FindCountOddElementsArray (int[] array)                                 // Кол-во нечетных чисел в массиве
{
    int CountOddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 1 == 0)
            CountOddElements = CountOddElements + 1;
    }
    return CountOddElements;
}


string exit = "n";
while (exit == "n")
{

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите размер массива: ");
        int size1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива (100): ");
        int LowLimit1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива (999): ");
        int PowLimit1 = Convert.ToInt32(Console.ReadLine());

        int[] numbers1 = FillArray(size1, LowLimit1, PowLimit1);
        Console.Write($"Заданный массив: [{String.Join(",",numbers1)}]");

        Console.WriteLine();
        Console.WriteLine($"Число четных чисел в массиве равно: {CountEvenElementsArray(numbers1)}");
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите размер массива: ");
        int size2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива: ");
        int LowLimit2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива: ");
        int PowLimit2 = Convert.ToInt32(Console.ReadLine());

        int[] numbers2 = FillArray(size2, LowLimit2, PowLimit2);
        Console.Write($"Заданный массив: [{String.Join(",",numbers2)}]");

        Console.WriteLine();
        Console.WriteLine($"Сумма нечётных элементов массива: {SumOddElementsArray(numbers2)}");
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите размер массива: ");
        int size3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива: ");
        int LowLimit3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива: ");
        int PowLimit3 = Convert.ToInt32(Console.ReadLine());

        int[] numbers3 = FillArray(size3, LowLimit3, PowLimit3);
        Console.Write($"Заданный массив: [{String.Join(",",numbers3)}]");

        Console.WriteLine();
        Console.Write($"Разница между максимальным {FindMaxElementArray(numbers3)} и минимальным {FindMinElementArray(numbers3)} значениями равно: {FindMaxElementArray(numbers3)-FindMinElementArray(numbers3)}");
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива."); 
        Console.WriteLine("Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите размер массива: ");
        int size4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива: ");
        int LowLimit4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива: ");
        int PowLimit4 = Convert.ToInt32(Console.ReadLine());

        int[] numbers4 = FillArray(size4, LowLimit4, PowLimit4);
        Console.Write($"Заданный массив: [{String.Join(",",numbers4)}]");
        Console.WriteLine(" ");

        double MidSumEvenElementsArray = FindSumEvenElementsArray (numbers4) / FindCountEvenElementsArray (numbers4);
        double MidSumOddElementsArray = FindSumOddElementsArray (numbers4) / FindCountOddElementsArray (numbers4);

        if (MidSumEvenElementsArray > MidSumOddElementsArray)
            Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] БОЛЬШЕ среднего арифметического нечетных элементов: [{MidSumOddElementsArray}]");
        if (MidSumEvenElementsArray < MidSumOddElementsArray)
            Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] МЕНЬШЕ среднего арифметического нечетных элементов: [{MidSumOddElementsArray}]");
        if (MidSumEvenElementsArray == MidSumOddElementsArray)
            Console.WriteLine($"Среднее арифметическое четных элементов: [{MidSumEvenElementsArray}] РАВНО среднему арифметическому нечетных элементов: [{MidSumOddElementsArray}]");
        break;

    default:
        Console.WriteLine("Такой задачи нет");
        break;
}
Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}