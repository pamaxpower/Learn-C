Console.Clear();

Console.WriteLine("Введите номер задачи (1,2,3,4,5), решение которой вы хотите посмотреть");
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
            // double exp = Math.Pow(A, B);

            double exp = 1;
                for (int i = 1; i <= B; i++)
                    {
                        exp =  exp * A;
                    }
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

    case 4:
        Console.Clear();
        Console.WriteLine("Задача 4. Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 "
                        + "и найти максимальное и минимальное значение среди них.");
        Console.WriteLine("Решение: ");
        Console.Clear();

        void RandomArray1 (int [] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                array[i] = new Random().Next(-10, 11);
            }
        }

        int MaxNum (int [] arr)
        {
            int max = -11;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max) max = arr[j];
            }
            return max;
        }
        int MinNum (int [] arr)
        {
            int min = 10;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < min) min = arr[j];
            }
            return min;
        }
        
        int [] numbers = new int [10];

        RandomArray1(numbers);
        Console.Write($"[{String.Join(",",numbers)}]");
        Console.WriteLine();
        Console.WriteLine($"Максимальное число равно {MaxNum(numbers)}");
        Console.WriteLine($"Минимальное число равно {MinNum(numbers)}");
        break;

    case 5:
        Console.Clear();
        Console.WriteLine("Задача 5. Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 "
                        + " и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый "
                        + " до целого числа результат переводим в двоичную систему счисления");
        Console.WriteLine("Решение: ");
        Console.Clear();
        Console.WriteLine("Введите количество элементов первого массива");
        int N1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов второго массива");
        int N2 = Convert.ToInt32(Console.ReadLine());

        void RandomArray2 (int [] array)         // Инициализация массива
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                array[i] = new Random().Next(0, 11);
            }
        }

        double MediumSumArray (int [] array)        // Нахождение среднего арифметического в массиве
        {
            int len = array.Length;
            double sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum = sum + array[i];
            }
            double medsum = sum / len;
            return medsum;
        }

        int [] numbers1 = new int [N1];
        int [] numbers2 = new int [N2];

        RandomArray2(numbers1);
        RandomArray2(numbers2);

        Console.WriteLine($"Первый массив: [{String.Join(",",numbers1)}]");
        Console.WriteLine($"Среднее арифметическое первого массива равно: {MediumSumArray(numbers1)}");
        Console.WriteLine($"Второй массив: [{String.Join(",",numbers2)}]");
        Console.WriteLine($"Среднее арифметическое второго массива равно: {MediumSumArray(numbers2)}");

        double count = 0;

        if (MediumSumArray(numbers1) > MediumSumArray(numbers2))        // Сравнение средних арифметических и нахождение разницы
        {
            count = Math.Round(MediumSumArray(numbers1) - MediumSumArray(numbers2), 0);
        }
        else 
        {
            count = Math.Round(MediumSumArray(numbers2) - MediumSumArray(numbers1), 0);
        }
        Console.WriteLine($"Разница между средними арифметическими: {count}");

        int[] b = new int[5]; 

        void ConvertNum10ToNum2 (int num)                       // Перевод в двоичное число
        {
            for (int i = 0; num >= 1; i++)                    // Деление на 2
                {
                    int a = Convert.ToInt32(num) % 2;
                    b[i] = a;
                    num = num / 2;
                }
            for (int j = (b.Length - 1); j >= 0; j--)           // Разворот массива
                    {
                        Console.Write(b[j]);
                    }
        }

        ConvertNum10ToNum2(Convert.ToInt32(count));
        break;
    
    default:
        Console.WriteLine("Такой задачи нет");
        break;
}