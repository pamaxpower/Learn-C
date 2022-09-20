// Создание метода поиска числа в случайном массиве

Console.Clear();
 
void FillArray(int[] collection)                        // Метод заполнения массива случайными числами
{                                                       
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)                              // Метод вывода на экран элементов массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
} 

int IndexOf(int[] collection, int find)                 // Метод поиска заданного числа в случайном массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1;                  // Чтобы не было ошибки в коде: если искомого элемента не будет в массиве, то программа выведет значение -1

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index; 
            break;                      // Завершаем цикл при первом положительном условии
        }
        index++;
    }
    return position;
}

int[] array = new int [10];                             

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
