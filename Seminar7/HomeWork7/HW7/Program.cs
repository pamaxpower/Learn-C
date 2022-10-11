// Домашнее задание №6

Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4), решение которой вы хотите посмотреть");
int zad = Convert.ToInt32(Console.ReadLine());


double [,] FillArrayDoubleNumbers (int rows, int columns)                         // Инициализация массива с вещественными числами
{
    double[,] filledArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = Convert.ToDouble(new Random().Next(-100,100) / 10.0);
            //filledArray[i, j] = Math.Round(Convert.ToDouble(new Random().NextDouble()),1);            // Заполняет числа от 0 до 1
        }
    }
    return filledArray;
}
void PrintDoubleArray (double [,] inputArray)                                     // Вывод массива c вещественными числамина экран
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i,j]);
        }
        Console.WriteLine();
    }
}

int[,] FillArray  (int rows, int columns, int min, int max)                       // Инициализация массива
{
    int[,] filledArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}
void PrintArray (int [,] inputArray)                                              // Вывод массива на экран
{  
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i,j]);
        }
        Console.WriteLine();
    }
}
void SearchElementByIndex (int[,] array, int a , int b)                           // Поиск элемента массив апо его индексу
{
    if(a >= array.GetLength(0) || b >= array.GetLength(1))
        Console.WriteLine("\nЭлемента с таким индексом в массиве нет");
    else Console.WriteLine($"\nЭлемент с таким индексом есть и он равен: {array[a,b]}");

}

void SumElementArrayColumn(int[,] inputArray)                                     // Сумма элементов столбца массива
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sumElementArrayColumn = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Сумма элементов {j+1} столбца равна: {sumElementArrayColumn}");
    }
}
void MidSumElementArrayColumn(int[,] inputArray)                                  // Среднее арифметическое столбца массива
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sumElementArrayColumn = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Среднее арифметическое элементов {j+1} столбца равна: {Math.Round(sumElementArrayColumn / inputArray.GetLength(0),1)}");
    }
}
void SumElementArrayRow(int[,] inputArray)                                        // Сумма элементов строки массива
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sumElementArrayColumn = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Сумма элементов {i+1} строки равна: {sumElementArrayColumn}");
    }
}
void MidSumElementArrayRow(int[,] inputArray)                                     // Среднее арифметическое строки массива
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        double sumElementArrayColumn = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Среднее арифметическое элементов {i+1} строки равна: {Math.Round(sumElementArrayColumn / inputArray.GetLength(1),1)}");
    }
}


void CompasionSumElement(int[,] inputArray)                                       // Сравнение суммы элементов столбца массива и суммы элементов углов массива
{
    int sumElementCornerArray = 0;
    sumElementCornerArray = inputArray[0,0] 
                          + inputArray[0,inputArray.GetLength(1)-1]
                          + inputArray[inputArray.GetLength(0)-1,0]
                          + inputArray[inputArray.GetLength(0)-1,inputArray.GetLength(1)-1];

    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sumElementArrayColumn = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    if (sumElementArrayColumn > sumElementCornerArray)
        Console.WriteLine($"Сумма элементов {j+1} столбца ({sumElementArrayColumn}) больше, чем сумма элементов углов массива ({sumElementCornerArray})");
    else Console.WriteLine($"Сумма элементов {j+1} столбца ({sumElementArrayColumn}) меньше, чем сумма элементов углов массива ({sumElementCornerArray})");
    }
    //Console.WriteLine($"НЕТ");
}

string exit = "n";
while (exit == "n")
{

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами. m = 3, n = 4.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите через пробел количество строк и столбцов: ");
        string[] arr1 = Console.ReadLine().Split();  
        int m1 = Convert.ToInt32(arr1[0]);
        int n1 = Convert.ToInt32(arr1[1]);

        double[,] array1 = FillArrayDoubleNumbers(m1,n1);
        PrintDoubleArray(array1);
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве "
                                    + "и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк");
        int rowCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int columnCount = int.Parse(Console.ReadLine());

        int[,] array2 = FillArray(rowCount, columnCount, 1 , 10);
        PrintArray(array2);

        Console.WriteLine("\nВведите индекс элемента (например 1,1): ");
        string[] arr2 = Console.ReadLine().Split(",");  
        int m2 = Convert.ToInt32(arr2[0]);
        int n2 = Convert.ToInt32(arr2[1]);
        SearchElementByIndex(array2, m2, n2);
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк");
        int rowCount3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int columnCount3 = int.Parse(Console.ReadLine());

        int[,] array = FillArray(rowCount3, columnCount3, 1 , 10);
        PrintArray(array);
        Console.WriteLine();
        // SumElementArrayColumn(array);                // Сумма элементов столбца
        // Console.WriteLine();
        MidSumElementArrayColumn(array);                // Среднее арифметическое элементов столбца
        // Console.WriteLine();
        // SumElementArrayRow(array);                   // Сумма элементов строки
        // Console.WriteLine();
        // MidSumElementArrayRow(array);                // Среднее арифметическое элементов строки
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, "
                                    + "больше суммы элементов расположенных в четырех углах двумерного массива.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк");
        int rowCount4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int columnCount4 = int.Parse(Console.ReadLine());

        int[,] array4 = FillArray(rowCount4, columnCount4, 1 , 10);
        PrintArray(array4);
        Console.WriteLine();
        CompasionSumElement(array4);
        break;

    default:
        Console.WriteLine("Такой задачи нет");
        break;
}

Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}









