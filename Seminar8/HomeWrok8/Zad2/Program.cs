/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 9);
PrintArray(array);
Console.WriteLine();
MaxSumElementArrayRow(array);
MinSumElementArrayRow(array);

int[,] FillArray  (int rows, int columns, int min, int max)
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

void PrintArray (int [,] inputArray)
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

void MaxSumElementArrayRow(int[,] inputArray)                                              // Определение строки с наибольшей суммой элементов
{
    int sumElementArrayRow = 0;
    int maxSum = 0;
    int countMax = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        sumElementArrayRow = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumElementArrayRow = sumElementArrayRow + inputArray[i, j];
        }
        if (sumElementArrayRow > maxSum)
        {
            maxSum = sumElementArrayRow;
            countMax = i + 1;
        }
    }
    Console.WriteLine($"\nНаибольшая сумма элементов ({maxSum}) находится в {countMax} строке");
}

void MinSumElementArrayRow(int[,] inputArray)                                              // Определение строки с наименьшей суммой элементов
{
    int sumElementArrayRow = 0;
    int minSum = 100;             // Изначально minSum должна быть не меньше максимально возможность суммы чисел в строке, т.е minSum = max * col
    int countMin = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        sumElementArrayRow = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumElementArrayRow = sumElementArrayRow + inputArray[i, j];
        }
        if (sumElementArrayRow < minSum)
        {
            minSum = sumElementArrayRow;
            countMin = i + 1;
        }
    }
    Console.WriteLine($"\nНаименьшая сумма элементов ({minSum}) находится в {countMin} строке");
}
