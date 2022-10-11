/* Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 9);
PrintArray(array);
Console.WriteLine();
SearchMinElements(array);
Console.WriteLine($"\nМинимальный элемент находится на позиции {SearchMinElements(array)}\n");
PrintArray(DeleteRowAndCol(array));

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

(int,int) SearchMinElements(int[,] arr)                     // Поиск минимального элемента в двумерном массиве
{                                           // (int,int) - если хотим вернуть два значение
    int minValue = array[0, 0];             // Первый элемент массива принимаем за минимальный
    int minIndexRow = 0;                    // Индекс минимального элемента в строке
    int minIndexCol = 0;                    // Индекс минимального элемента в столбце

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                minIndexRow = i;
                minIndexCol = j;
            }
        }
    }
    return (minIndexRow, minIndexCol);      // Возвращаем два значения
}

int[,] DeleteRowAndCol (int[,] arr)                         // Удаление строки и столбца с минимальным значение
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int[,] deleteArray = new int [row-1, col-1];
    int RowCount = 0;                                       // Вводим счетчик строк и столбцов
    int ColCount = 0;                                       // для того, чтобы при удалении строки и столбца индекс не вышел за пределы массива
    for (int i = 0; i < row; i++)                           // Цикл по строчкам
    {
        if (i == SearchMinElements(arr).Item1)              // Проверяем строчку на равенство с той, которую надо удалить
        {                                                   // Item1 - берет только первое значение из метода
            continue;                                       // пропускаем тот элемент, который нам не нужен
        }
        for (int j = 0; j < col; j++)
        {
            if (j == SearchMinElements(arr).Item2)          // Цикл по столбцам
            {
                continue;
            }
            deleteArray[RowCount,ColCount] = arr[i,j];
            ColCount++;                                     // Увеличиваем счетчик по столбцам так как мы еще в цикле заполнения стобцами
        }
        ColCount = 0;                                       // Обнуляем счетчик по столбцам, тк вышли из цикла слолбцов
        RowCount++;                                         // Увеличиваем счетчик по строкам, так как закончили заполнение и переходим к следующей
    }
    return deleteArray;
}


