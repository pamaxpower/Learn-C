/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.Clear();
/*
void RandomArray(int[] col)                        
{                                                     
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] col)
{
    for (int pos = 0; pos < col.Length; pos++)
    {
        Console.Write(col[pos] + " ");
    }
} 
int[] array = new int [8];                            
RandomArray(array);
PrintArray(array);
*/

int[] Random01(int[] array_local)
{
    Random rnd = new Random();
    for (int i = 0; i < array_local.Length; i++)
    {
        array_local[i] = rnd.Next(0, 2);
    }
    return array_local;
}

int[] array = new int[8];
array = Random01(array);

Console.Write(String.Join(",",array));