﻿// Найти элемент массива равный заданному числу

Console.Clear();

int[] array = {1, 47, 54, 24, 36, 28, 91, 17, 24};
int n = array.Length;                                   // Вводим переменную, которая содержит в себе длину массива
int find = 24;                                          // Вводим число, которое надо найти

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                                          // Прерывание действий цикла. При одинаковых элементах в массиве, программа будет выводить 
    }                                                   // на экран значения всех индексов. Чтобы этого не было, используют оператор break
    index++;
}
