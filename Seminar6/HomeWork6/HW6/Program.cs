// // Домашнее задание №6
0
Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4), решение которой вы хотите посмотреть");
int zad = Convert.ToInt32(Console.ReadLine());

int[] FillArray (int size, int LowLimit, int PowLimit)                          // Инициализация массива
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}
int[] LeftShiftArray (int[] arr)                                                // Сдвиг массива влево на 1 элемент
{
    int[] leftShift = new int[arr.Length];
    for (int i = 0; i < arr.Length-1; i++)
    {
        leftShift[i] = arr[i+1];
    }
    leftShift[arr.Length-1] = arr[0];

    return leftShift;
}
int[] RigthShiftArray (int[] arr)                                               // Сдвиг массива впрапво на 1 элемент
{
    int[] rigthShift = new int[arr.Length];
    for (int i = 1; i < arr.Length; i++)
    {
        rigthShift[i] = arr[i-1];
    }
    rigthShift[0] = arr[arr.Length-1];

    return rigthShift;
}

void ChangeElementsArray(int[] arr)                                             // Замена повторяющегося элемента, если рядом стоит одинаковый по значению элемент
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1]) arr[i + 1] = arr[i + 1] + 1;
    }
    Console.WriteLine($"Измененный массив: {String.Join(",", arr)} ");
}
/*
void ChangeElementsArray(int[] arr)
{
    int n = max + 1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            arr[i + 1] = n;
            n = n + 1;
        }
    }
    Console.WriteLine($"Измененный массив: {String.Join(",", arr)} ");
}
*/

string exit = "n";
while (exit == "n")
{

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine("Решение: ");
    
        Console.WriteLine("Введите числа через пробел: ");
        string[] arr= Console.ReadLine().Split();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToInt32(arr[i]) > 0) count++;
            }
        Console.WriteLine($"Количество чисел больше 0 равно: {count}");
        break;
    
    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. " 
                                    + "Значения b1, k1, b2 и k2 задаются пользователем.");
        Console.WriteLine("Решение: ");
        
        Console.WriteLine("Введите k1: ");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b1: ");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите k2: ");
        double k2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b2: ");
        double b2 = Convert.ToInt32(Console.ReadLine());
            double x = 0;
            double y = 0;

        if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельные - нет точки пересечения");
        else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают - все точки общие");
        else {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            Console.WriteLine($"Прямые пересекаются в точке ({Math.Round(x,2)} ; {Math.Round(y,2)})");
        }
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями "
                                    + "и сдвинуть элементы массива влево, или вправо на 1 позицию.");
        Console.WriteLine("Решение: ");
        
        Console.WriteLine("Введите количество чисел: ");
        int M3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива: ");
        int min3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива: ");
        int max3 = Convert.ToInt32(Console.ReadLine());
        int[] array3 = FillArray(M3, min3, max3);

        Console.WriteLine($"Заданный массив: {String.Join(",",array3)} ");
        Console.WriteLine($"Сдвиг влево: {String.Join(",",LeftShiftArray(array3))} ");
        Console.WriteLine($"Сдвиг влево: {String.Join(",",RigthShiftArray(array3))} ");
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить "
                                    + "существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите количество чисел: ");
        int M4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите нижний предел массива: ");
        int min4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите верхний предел массива: ");
        int max4 = Convert.ToInt32(Console.ReadLine());
        int[] array4 = FillArray(M4, min4, max4);

        Console.WriteLine($"Заданный массив: {String.Join(",",array4)} ");
        ChangeElementsArray(array4);
        break;

    default:
        Console.WriteLine("Такой задачи нет");
        break;
}
Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}



