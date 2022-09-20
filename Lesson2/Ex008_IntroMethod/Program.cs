// Найти максимум из 9 чисел с помощью функции

Console.Clear();

int Max(int arg1, int arg2, int arg3)           // задаем функцию с названием Max
{
    int result = arg1;                          // В теле функции пишем действия, которые она выполняет
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;           
    return result;                              // Возвращем переменную (Итог, который дает функция)
} 
int a1 = -1;
int a2 = 4220;
int a3 = -145;
int b1 = -5;
int b2 = -2306;
int b3 = -54;
int c1 = -89;
int c2 = -21;
int c3 = -5;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); 

int max = Max(                                  // Сокращенная запись 22,23,24,25 строчек
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);