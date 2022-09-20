// Найти максимум из массива из 9 чисел с помощью функции

Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} 
//              0  1  2  3  4  5  6  7  8
int[] array = {15,25,55,138,23,74,96,45,83};         // Задаем массив
//array[0] = 12;                                      // Обращаемся к элементу и присваеваем ему новое значение
// Console.WriteLine(array[0]);                        // Выводим элемент на экран

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);