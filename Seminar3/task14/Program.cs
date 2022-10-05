/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
 
double a = x1 - x2;
double b = y1 - y2;
double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));                              // Math.Sgrt() - извлечение квадратного корня
                                                                                    // Math.Pow(основание стпени, показатель степени) - возведение в степень

Console.WriteLine($"Расстояние между точками равно: {Math.Round(c,3)}");            // Math.Round(значение, число знаков после запятой) - округление
