// Здесь собраны все задачи домашнего задания

Console.Clear();

Console.WriteLine("Введите номер задачи, решение которой вы хотите посмотреть");
int zad = int.Parse(Console.ReadLine());

switch (zad)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите любое пятизначное число");
        int num = int.Parse(Console.ReadLine());

        if (num > 9999 && num < 100000) 
        {
            int digit1 = num.ToString()[0];
            int digit2 = num.ToString()[1];
            int digit4 = num.ToString()[3];
            int digit5 = num.ToString()[4];

            if (digit1 == digit5 && digit2 == digit4) 
            {
                Console.WriteLine($"Число {num} является палиндромом");
            } 
            else 
                Console.WriteLine($"Увы, число {num} не палиндромом");
            
        } else Console.WriteLine("Вы ввели не пятизначное число. Будьте внимательны!");
        break;   

    case 2:
        Console.Clear();
        Console.WriteLine("Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("x1= ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("y1= ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("z1= ");
        int z1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("x2= ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("y2= ");
        int y2 = int.Parse(Console.ReadLine());
        Console.Write("z2= ");
        int z2 = int.Parse(Console.ReadLine());

        double a = x1 - x2;
        double b = y1 - y2;
        double c = z1 - z2;
        double d = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2) + Math.Pow(c,2));

        Console.WriteLine($"Расстояние между точками равно: {Math.Round(d,2)}");
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine("Решение: ");
        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int count = 1;

        while (count <= number)
        {
            double cube = Math.Pow(count, 3);
            Console.Write(cube + " ");
            count++;
        }
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.");
        Console.WriteLine("Введите радиус круга");
        int r = int.Parse(Console.ReadLine());
        double squareCircle = Math.PI * Math.Pow(r, 2);
        int num1 = Convert.ToInt32(Math.Round(squareCircle, 0));
        Console.WriteLine($"Площадь круга равна: {num1}");
        int maxnum = 0;
        while (num1 > 0)
        {
                if (maxnum < num1 % 10)
                maxnum = num1 % 10;     
                num1 = num1 / 10;
        }
        Console.WriteLine(maxnum);
        break;

    default:
        Console.WriteLine("Вы ввели неверное число");
        break;
}


