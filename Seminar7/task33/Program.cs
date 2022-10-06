/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Изначальный массив: 	
1 4 7 2
5 9 2 3
8 4 2 4
Итоговый массив: 	
8 4 2 4
5 9 2 3
1 4 7 2
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 9);
PrintArray(array);
Console.WriteLine();
ChangeRows(array);
PrintArray(array);

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


int [,] ChangeRows (int[,] array)                                       // Замена первой и последней строки
{
    int[,] changeArray = new int [array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
    return changeArray;
}
