/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

*/

Console.Clear();

Console.WriteLine("Количество строк");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1 , 9);
PrintArray(array);
Console.WriteLine();
Convert2dArrayInString(array);
Console.WriteLine($"{String.Join(",",Convert2dArrayInString(array))}");
Console.WriteLine();
//QuantitativeGlossaryElements(Convert2dArrayInString(array));
PrintData(Convert2dArrayInString(array));

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

int[] Convert2dArrayInString(int[,] inputArray)                 // Конвертация двумерного массива в одномерный
{
    int row = inputArray.GetLength(0);
    int col = inputArray.GetLength(1);
    int[] convertArray = new int[row * col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            int index = j + (col * i);                          // Индекс элемента одномерного массива
            convertArray[index] = inputArray[i, j];
        }
    }
    Array.Sort(convertArray);                                   // Сортировка массива от меньшего к большему значению
    return convertArray;
}
/*
void QuantitativeGlossaryElements (int [] inputArray)
{

    for (int i = 0; i < inputArray.Length; i++)
    {
        int counter = 0;
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[i] == inputArray[j]) counter++; 
        }
        Console.WriteLine($"Число {inputArray[i]} встречается {counter} раз");
    }
}
  */
void PrintData(int[] inArray)                                   // Считаем количество элементов и выводим на экран
{
    int el = inArray[0];                                        // Вводим переменную, которой присваиваем значение 1 элемента массива
    int count = 1;                                              // Счетчик сколько раз переменная встречается(работает только на первое число)
    for (int i = 1; i < inArray.Length; i++)                    // Перебор по элементам массива, начиная со 2
    {
        if (inArray[i] != el)                                   // Проверяем на повторение (отличен ли он предыдущего)
        {
            Console.WriteLine($"{el} встречается {count}");     // Если элемент не равен предыдущему, то он принимается за переменную и вводится счетчик
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;                                            // Если элемент равен предыдущему, то работает счетчик
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}