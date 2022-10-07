/*
Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

Console.WriteLine("Введите через пробел количество строк и столбцов: ");
string[] arr = Console.ReadLine().Split();  
int m = Convert.ToInt32(arr[0]);
int n = Convert.ToInt32(arr[1]);

double[,] array = FillArrayDoubleNumbers(m,n);
PrintArray(array);

double [,] FillArrayDoubleNumbers (int rows, int columns)
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

void PrintArray (double [,] inputArray)
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
