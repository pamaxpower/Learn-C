/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

**Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон**
*/

Console.Clear();

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());


if (a < b + c && b < a + c && c < a + b) Console.WriteLine($"Треугольник может существовать со сторонами {a}, {b}, {c}");
else Console.WriteLine($"Нельзя составить треугольник со сторонами: {a}, {b}, {c}");


/*
int max = 0;
max = (a > b) ? a : 0;                  // Если a > b, то max = a
max = (max < c) ? c : 0;                // Если max < c, то max = c
string output = (max < (a + b)) ? "Треугольник существует" : "Треугольник не существует";   // Если max < a+b, то output примет значение "Треугольник существует",
                                                                                            // если нет - то выдаст "Треугольник не существует"
Console.WriteLine(output);
*/