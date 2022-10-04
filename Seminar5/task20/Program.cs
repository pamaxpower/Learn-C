/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

Console.Clear();

/*
void FillRandomArray(int[] array, int LowLimit, int UpLimit)        // Способ, где задаем параметры с клавиатуры
{
    for (int index=0; index < array.Length; index++)
    {
        array[index] = new Random().Next(LowLimit, UpLimit + 1);
    }
}

Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int [size];

FillRandomArray(numbers, min, max);
Console.Write($"[{String.Join(",",numbers)}]");
*/

int[] FillArray (int size, int min, int max)                        // Способ, где вводим параметры сразу в код 
{
    int[] filledArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
}

int[] numbers = FillArray(12, -9, 9);
Console.Write($"[{String.Join(",",numbers)}]");
Console.WriteLine();

int SumNegativeNumber = 0;
int SumPositiveNumber = 0;
/*
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        SumNegativeNumber = SumNegativeNumber + numbers[i];
    }
    else
    {
        SumPositiveNumber = SumPositiveNumber + numbers[i];
    }
}
*/
foreach (int element in numbers)                                // Цикл foreach перебирает каждый элемент в массиве
{
    SumNegativeNumber += element > 0 ? element : 0;             // Запись читается как:
                                                                // if (element > 0) SumNegativeNumber += element;
                                                                // else SumNegativeNumber += 0;
    SumPositiveNumber += element < 0 ? element : 0;
}


Console.WriteLine($"Сумма отрицательных чисел равна: {SumNegativeNumber}");
Console.WriteLine($"Сумма положительных чисел равна: {SumPositiveNumber}");

