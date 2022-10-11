/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Исходный массив:                Результат замены:
9 2 3                            9 4 2
4 2 4                            2 2 6 
2 6 7                            3 4 7
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 9);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(ChangeArray(array));


int[,] FillArray(int rows, int columns, int min, int max)
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

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0,3}", inputArray[i, j]); // {0,3} -> 3 - расстояние между позициями массива
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int [,] inputArray)              // Замена местами строчек и столбцов
{
    int row = inputArray.GetLength(0);
    int col = inputArray.GetLength(1);
    int[,] changeArray = new int[col, row];         // Создается новый массив, где кол-во строк равно кол-ву столбцов исходного массива. И также со столбцами
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            changeArray[i, j] = inputArray[j, i];
        }
    }
    return changeArray;
}