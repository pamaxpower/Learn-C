/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

Console.WriteLine("Количество строк первой матрицы");
int rowCount1 = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов первой матрицы");
int columnCount1 = int.Parse(Console.ReadLine());
Console.WriteLine("Количество строк второй матрицы");
int rowCount2 = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов второй матрицы");
int columnCount2 = int.Parse(Console.ReadLine());

int[,] array1 = FillArray(rowCount1, columnCount1, 1, 9);
int[,] array2 = FillArray(rowCount1, columnCount2, 1, 9);

Console.WriteLine($"Первая матрица: ");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine($"Вторая матрица: ");
PrintArray(array2);
Console.WriteLine();
PrintArray(MultiplicationMatrix(array1, array2));

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
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int row1 = matrix1.GetLength(0);
    int col1 = matrix1.GetLength(1);
    int row2 = matrix2.GetLength(0);
    int col2 = matrix2.GetLength(1);
    int[,] multiMatrix = new int[0,0];

    if (col1 == row2) 
    {   
        multiMatrix = new int[row1, col2];
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col2; j++)
            {
                multiMatrix[i, j] = 0;
                for (int k = 0; k < col1; k++)
                {
                    multiMatrix[i, j] = multiMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    else Console.WriteLine("Эти матрицы нельзя перемножить. Введите другие\n");
    return multiMatrix;
}


