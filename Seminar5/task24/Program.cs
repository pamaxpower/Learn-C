/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int[size];
    for (int i=0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

int[] numbers = FillArray (9, 1, 10);
Console.WriteLine($"Заданный массив: [{String.Join(",",numbers)}]");

int[] MultNum (int[] array)
{
    int len = 0;
    if (array.Length % 2 == 0)                              // Проверка на четность количества элементов массива (для того, чтобы определить количество пар -> длину преобразованного массива)
        len = array.Length / 2;
    else 
        len = array.Length / 2 + 1;
    
    int[] halfArray = new int [len];

    for (int i = 0; i < len; i++)
    {
        halfArray[i] = array[i] * array[array.Length-i-1];
    }

    if (array.Length % 2 == 1)                              // если массив с нечетным числом элементов, то "среднее" число просто переходит в новый массив
                                                            // если этого не сделать то средний элемент умножится сам на себя
        halfArray[len-1] = array[len-1];

    return halfArray;
}  
Console.WriteLine($"Преобразованный массив: [{String.Join(",",MultNum(numbers))}]");
   
 //   return halfArray;
//}
//Console.WriteLine(MultNum(numbers));


