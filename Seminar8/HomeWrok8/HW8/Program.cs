// Домашнее задание №8

Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4), решение которой вы хотите посмотреть");
int zad = Convert.ToInt32(Console.ReadLine());

int[,] FillArray  (int rows, int columns, int min, int max)         // Инициализация двумерного массива
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
void PrintArray (int [,] inputArray)                                // Вывод двумерного массива
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
void OrderedArray (int[,] inputArray)                               // Сортировка элементов в строке
{
    int row = inputArray.GetLength(0);
    int col = inputArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int l = 0; l < col-1; l++)                 
            {
                if (inputArray[i,l] < inputArray[i,l+1])
                {
                    int temp = inputArray[i,l];
                    inputArray[i,l] = inputArray[i,l+1];
                    inputArray[i,l+1] = temp;
                }
            }
        }
    }
}
void MinSumElementArrayRow(int[,] inputArray)                       // Определение строки с наименьшей суммой элементов
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
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)         // Произведение матриц
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
int[,,] FillArray3d(int min, int max)                               // Инициализация трехмерного массива
{
    int[,,] filledArray = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                filledArray[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return filledArray;
}
void PrintArray3d (int [,,] inputArray)                             // Вывод трехмерного массива
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"{inputArray[i,j,k]} ({i},{j},{k}) "); 
            }
        }
        Console.WriteLine();
    }
}

string exit = "n";
while (exit == "n")
{

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк");
        int rowCount1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int columnCount1 = int.Parse(Console.ReadLine());
        int[,] array1 = FillArray(rowCount1, columnCount1, 1 , 9);
        PrintArray(array1);
        Console.WriteLine();
        OrderedArray(array1);
        PrintArray(array1);
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк");
        int rowCount2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int columnCount2 = int.Parse(Console.ReadLine());

        int[,] array2 = FillArray(rowCount2, columnCount2, 1 , 9);
        PrintArray(array2);
        Console.WriteLine();
        MinSumElementArrayRow(array2);
        break;
    
    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Количество строк первой матрицы ");
        int rowCount3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов первой матрицы ");
        int columnCount3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество строк второй матрицы");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов второй матрицы");
        int col = int.Parse(Console.ReadLine());

        int[,] matr1 = FillArray(rowCount3, columnCount3, 1, 9);
        int[,] matr2 = FillArray(row, col, 1, 9);

        Console.WriteLine($"Первая матрица: ");
        PrintArray(matr1);
        Console.WriteLine();
        Console.WriteLine($"Вторая матрица: ");
        PrintArray(matr2);
        Console.WriteLine();
        PrintArray(MultiplicationMatrix(matr1, matr2));
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Сформируйте трёхмерный массив размером 2х2х2 из неповторяющихся двузначных чисел. "
                                    + "Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("Решение: ");
        
        int[,,] array = FillArray3d(10 , 99);
        PrintArray3d(array);
        Console.WriteLine();
        break;

    default:
        Console.WriteLine("Такой задачи нет");
        break;
}

Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}



