/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine("Введите неотрицательное число");

Console.WriteLine($"A({m},{n}) = {FunctionAkkerman(m, n)}");

int FunctionAkkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (b == 0) return FunctionAkkerman(a - 1, 1);
    return FunctionAkkerman(a - 1, FunctionAkkerman(a, b - 1));
}