// Домашнее задание №9

Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4,5), решение которой вы хотите посмотреть");
int zad = Convert.ToInt32(Console.ReadLine());

void EvenNumRec(int m, int n)                               // Четные натуральные числа
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    EvenNumRec(m+1,n);
}
int SumNumberRec (int a, int b)                             // Сумма чисел
{
    int sum = 0;
    if (a <= b) 
    {
        sum = a + SumNumberRec(a+1,b);
    }
    return sum;
}
int GreatestCommonDivisitor(int a, int b)                   // Наибольший общий делитель
{
    int gcd = 0;
    if (a < 0) return gcd = GreatestCommonDivisitor(-a, b);     // Если числа отрицательные
    if (b < 0) return gcd = GreatestCommonDivisitor(a, -b);
    if (a == 0) return gcd = b;                                 // ноль делится на любое число
    if (b == 0) return gcd = a;
    if (a == b) return gcd = a;
    if (a == 1 && b == 1) return gcd = 1;                       // единица имеет только один делитель: 1
    if (a % b > 0)                                              // Остаток от деления больше 0
    {
        return gcd = GreatestCommonDivisitor(b, a % b);
    }
    else return b;
}
int FunctionAkkerman(int a, int b)                          // Функция Аккермана
{
    if (a == 0) return b + 1;
    if (b == 0) return FunctionAkkerman(a - 1, 1);
    return FunctionAkkerman(a - 1, FunctionAkkerman(a, b - 1));
}
void PrintTriangle(int a)                                   // Построение треугольника
{
    for (int i = 1; i <= a; i++)
    {
        for (int c = 1; c <= a - i; c++)
        {
            Console.Write(" ");
        }

        for (int c = 1; c <= i; c++)
        {
            Console.Write(" "); 
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

string exit = "n";
while (exit == "n")
{

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите число M");
        int M1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N");
        int N1 = Convert.ToInt32(Console.ReadLine());

        EvenNumRec(M1,N1);
        Console.WriteLine();
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите число M");
        int M2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N");
        int N2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма чисел от {M2} до {N2} равна {SumNumberRec(M2,N2)}" );
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");
        Console.WriteLine("Решение: ");
    
        Console.WriteLine("Введите число M");
        int M3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N");
        int N3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Наибольший общий делитель чисел {M3} и {N3} равен {GreatestCommonDivisitor(M3, N3)}");
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("Решение: ");

        Console.WriteLine("Введите число M");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m < 0 || n < 0) Console.WriteLine("Введите неотрицательное число");

        Console.WriteLine($"A({m},{n}) = {FunctionAkkerman(m, n)}");
        break;

    case 5:
        Console.Clear();
        Console.WriteLine("Задача 5. Напишите программу, которая выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии");
        Console.WriteLine("Решение: ");

        Console.Write("Введите количество строк ");
        int n5 = int.Parse(Console.ReadLine());

        PrintTriangle(n5);
        break;
        
    default:
        Console.WriteLine("Такой задачи нет");
        break;
}

Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}






