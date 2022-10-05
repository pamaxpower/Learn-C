// Инициализация двумерного массива и вывод его на печать

Console.Clear();
/*
string[,] table = new string [2, 5];                     // Задаем таблицу строк
// String.Empty
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table[1,2] ... table[1,4]


table [1, 2] = "слово";                                 // Обращение к элементу массива, находящемся на 1 строчке, 2 столбца. И присваивание ему значения "слово"

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} 
*/
int[,] matrix = new int[3, 4];                          // Задаем матрицу чисел

for (int i = 0; i < matrix.GetLength(0); i++)           // matrix.GetLength(0) = 3 - количество строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)       // matrix.GetLength(1) = 4 - количество столбцов
    {
        Console.Write($"{matrix[i, j]} ");              // Вывод всех столбиков одной строки
    }
Console.WriteLine();                                    // Переход на новую строку
} 
