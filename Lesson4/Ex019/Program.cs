// Методы по случайному заполнению и выводу на экран двумерного массива

Console.Clear();


void PrintArray (int [,] matr)                     
{
    for (int i = 0; i < matr.GetLength(0); i++)           
    {
        for (int j = 0; j < matr.GetLength(1); j++)       
        {
            Console.Write($"{matr[i, j]} ");              
        }
    Console.WriteLine();                                    
    }
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)           
    {
        for (int j = 0; j < matr.GetLength(1); j++)       
        {
            matr[i,j] = new Random().Next(1,10);             // Задаем числа из диапазона [1,10)
        }
    }
}

int[,] matrix = new int [4, 5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();                                    
PrintArray(matrix);