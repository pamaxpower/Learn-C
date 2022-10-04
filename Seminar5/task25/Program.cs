
// Перевод числа в двоичную систему


Console.WriteLine("ВВедите число");
int count = Convert.ToInt32(Console.ReadLine());

string ConvertNum10ToNum2 (int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = Convert.ToInt32(num) % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine(ConvertNum10ToNum2(Convert.ToInt32(count)));