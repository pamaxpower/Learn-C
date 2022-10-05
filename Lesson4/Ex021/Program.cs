// Метод вычисление факториала

Console.Clear();

double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;               // по определению факториала
    else return n * Factorial (n-1);
}

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Примерно с 13! значение int переполняются, поэтому для определения метода поиска факториала лучше использовать тип данных double
