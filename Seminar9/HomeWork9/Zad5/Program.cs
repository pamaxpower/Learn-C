/* Напишите программу, которая выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии

N = 5 ->
    1
   2 2
  3 3 3
 4 4 4 4 
5 5 5 5 5
*/

Console.Clear();

Console.Write("Введите количество строк ");
int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

void PrintTriangle(int a)                           // Построение треугольника
{
    for (int i = 1; i <= a; i++)
    {
        for (int c = 1; c <= a - i; c++)            // a-i - кол-во отступов от левой стороны консоли (чем ниже строка, тем меньше отступ)
        {
            Console.Write(" ");
        }

        for (int c = 1; c <= i; c++)
        {
            Console.Write(" ");                     // пробелы между элементами треугольника
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
