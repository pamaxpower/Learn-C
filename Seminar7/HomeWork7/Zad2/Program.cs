/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет
*/


Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 10);
PrintArray(array);

Console.WriteLine("\nВведите индекс элемента: ");
string[] arr = Console.ReadLine().Split(",");  
int m = Convert.ToInt32(arr[0]);
int n = Convert.ToInt32(arr[1]);
SearchElementByIndex(array, m, n);

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

void SearchElementByIndex (int[,] array, int a , int b)                             // Поиск элемента массив апо его индексу
{
    if(a >= array.GetLength(0) || b >= array.GetLength(1))
        Console.WriteLine("\nЭлемента с таким индексом в массиве нет");
    else Console.WriteLine($"\nЭлемент с таким индексом есть и он равен: {array[a,b]}");

}


