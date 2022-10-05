// Метод вычисление чисел Фибоначчи

Console.Clear();

double Fibonacci (int n)
{
    // f(1) = 1
    // f(2) = 1, тк 0+1=1
    // f(3) = 2, тк 1+1=2
    // f(n) = f(n-1) + f(n-2)
    if (n == 1 || n == 2) return 1;               // по определению факториала
    else return Fibonacci (n-1) + Fibonacci (n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($" f({i}) = {Fibonacci(i)}");
}

// Примерно с 35-40 числа значения начинают выводиться очень медленно