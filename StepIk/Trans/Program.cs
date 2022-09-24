// Написать программу для перевода десла из десятичной системы в двоичную

Console.Clear();

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
// int[] array = new int [10]; 
int i = 0;

while (num >= 1)
{
    a = num % 2;
    // array[i] = a;
    i++;
    num = num / 2;
    Console.Write(a);
}
