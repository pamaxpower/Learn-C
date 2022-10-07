/* Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого,
больше суммы элементов расположенных в четырех "углах" двумерного массива.
Например, задан массив:
4 4 7 5                                 2 4 7 2
4 3 5 3                                 4 3 5 3
8 1 6 8 -> нет                          2 1 6 2 -> да
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 10);
PrintArray(array);
Console.WriteLine();
//SumElementCornerArray(array);
CompasionSumElement(array);


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
/*
void SumElementCornerArray (int [,] inputArray)                                     // Сумма элементов углов массива
{
    int sumElementCornerArray = 0;
    sumElementCornerArray = inputArray[0,0] 
                          + inputArray[0,inputArray.GetLength(1)-1]
                          + inputArray[inputArray.GetLength(0)-1,0]
                          + inputArray[inputArray.GetLength(0)-1,inputArray.GetLength(1)-1];
    Console.WriteLine($"Сумма элементов углов массива равна: {sumElementCornerArray}");
}
*/
void CompasionSumElement(int[,] inputArray)                                         // Сравнение суммы элементов столбца массива и суммы элементов углов массива
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
    }
    //Console.WriteLine($"НЕТ");
}
