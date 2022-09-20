// Написание методов для создания массива со случайным заполнение чисел и метода для вывода этого массива на экран.

Console.Clear();
 
void FillArray(int[] collection)                        // void - используется, если функция(метод) не возвращает никакое значение.
{                                                       // в таком случае оператор return не используется.
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
} 


int[] array = new int [10];                             // создай новый массив, в котором будет 10 элементов (по умолчанию будет нулями)

FillArray(array);
PrintArray(array);
