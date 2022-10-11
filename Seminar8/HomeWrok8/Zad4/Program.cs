/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int[,,] array = FillArray3d(10 , 99);
PrintArray3d(array);
Console.WriteLine();

int[,,] FillArray3d(int min, int max)
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

void PrintArray3d (int [,,] inputArray)
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
