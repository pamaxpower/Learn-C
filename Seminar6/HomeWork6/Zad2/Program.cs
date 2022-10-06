/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();

Console.WriteLine("Введите через пробел k1,b1 и k2,b2: ");
string[] arr = Console.ReadLine().Split();  
double k1 = Convert.ToDouble(arr[0]);
double b1 = Convert.ToDouble(arr[1]);
double k2 = Convert.ToDouble(arr[2]);
double b2 = Convert.ToDouble(arr[3]);

/*
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
*/

double x = 0;
double y = 0;

if (k1 == k2 && b1 != b2)                                               // Проверка на параллельность
{
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} параллельные - нет точки пересечения");
}
else if (k1 == k2 && b1 == b2)                                          // Проверка на совпадение
{
    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} совпадают - все точки общие");
}

else
{
    x = (b2 - b1) / (k1 - k2);                                          // выводится из системы уравнений: k1*x+b1 = k2*x+b2
    y = k1 * x + b1;                                                    // полученный x подставляем в любой уравнение и находим y

    Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} пересекаются в точке ({Math.Round(x,2)} ; {Math.Round(y,2)})");
}




