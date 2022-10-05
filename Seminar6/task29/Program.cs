/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Число {num} в двоичном виде: {Convert.ToString(num, toBase: 2)}");     // через команду

int[] arr = new int[10]; 

void ConvertNum10ToNum2 (int num10)                       // Перевод в двоичное число
{
    for (int i = 0; num10 >= 1; i++)                      // Деление на 2
        {
            arr[i] = num10 % 2;
            num10 = num10 / 2;
        }
    for (int j = (arr.Length - 1); j >= 0; j--)               // Разворот массива
            {
                Console.Write(arr[j]);
            }
}
Console.WriteLine();
ConvertNum10ToNum2(num);

/*
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
*/