/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1= ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1= ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1= ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2= ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2= ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2= ");
int z2 = Convert.ToInt32(Console.ReadLine());

double a = x1 - x2;
double b = y1 - y2;
double c = z1 - z2;
double d = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2) + Math.Pow(c,2));

Console.WriteLine($"Расстояние между точками равно: {Math.Round(d,2)}");

// Скорее всего можно сократить, но пока не догадываюсь как