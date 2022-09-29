Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3), решение которой вы хотите посмотреть");
int zad = int.Parse(Console.ReadLine());

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите число A: ");
        double A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        double B = Convert.ToInt32(Console.ReadLine());

        if (A == 0 && B < 0)
        {
            Console.WriteLine("Деление на 0");
        }
        else
        {
            double exp = Math.Pow(A, B);
            Console.WriteLine($"Если число {A} возвести в степень {B}, то получится {exp}");
        }
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int SumDigit (int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int a = number - (number / 10)*10;
                number = number / 10;
                sum = sum + a;
            }
            return sum;
        } 
        Console.WriteLine($"Сумма цифр в числе {num} равно {SumDigit(num)}");
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите число элементов массива: ");
        int N = Convert.ToInt32(Console.ReadLine());

        void RandomArray(int[] arr)                        
        {                                                     
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next();               // Предел можно задать любой, а оставил по умолчанию все целые числа
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
        break;

    default:
        Console.WriteLine("Такой задачи нет");
        break;
}