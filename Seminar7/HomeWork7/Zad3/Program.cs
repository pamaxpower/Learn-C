/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 10);
PrintArray(array);
Console.WriteLine();
SumElementArrayColumn(array);
Console.WriteLine();
MidSumElementArrayColumn(array);
Console.WriteLine();
SumElementArrayRow(array);
Console.WriteLine();
MidSumElementArrayRow(array);



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

void SumElementArrayColumn(int[,] inputArray)                                           // Сумма элементов столбца массива
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
void MidSumElementArrayColumn(int[,] inputArray)                                        // Среднее арифметическое столбца массива
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sumElementArrayColumn = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Среднее арифметическое элементов {j+1} столбца равна: {Math.Round(sumElementArrayColumn / array.GetLength(0),1)}");
    }
}
void SumElementArrayRow(int[,] inputArray)                                              // Сумма элементов строки массива
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
void MidSumElementArrayRow(int[,] inputArray)                                           // Среднее арифметическое строки массива
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        double sumElementArrayColumn = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumElementArrayColumn = sumElementArrayColumn + inputArray[i,j];
        }
    Console.WriteLine($"Среднее арифметическое элементов {i+1} строки равна: {Math.Round(sumElementArrayColumn / array.GetLength(1),1)}");
    }
}


