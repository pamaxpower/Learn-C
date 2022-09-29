/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

Console.WriteLine("Введите число элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

void RandomArray(int[] arr)                        
{                                                     
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}
void PrintArray(int[] col)
{
    for (int pos = 0; pos < col.Length; pos++)
    {
        Console.Write(col[pos] + " ");
        // Console.Write(String.Join(",",col[pos]));        // почему то не работает, выдает "слипшуюся" строчку
    }
} 

int[] array = new int [N];                            
RandomArray(array);
PrintArray(array);

