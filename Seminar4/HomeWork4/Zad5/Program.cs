/*
Напишите программу, которая задаёт 2 одномерных массива из N элементов которые заполняются случайными значениями в диапазоне от 1 до 10 
и находит среднее арифметическое элементов этих 2 массивов, далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый 
до целого числа результат переводим в двоичную систему счисления.

[1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними арифметическими массивов = 2. 2 в двоичной системе счисления = 10
[4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними арифметическими массивов = 4. 4 в двоичной системе счисления = 100
*/

Console.Clear();

Console.WriteLine("Введите количество элементов первого массива");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов второго массива");
int N2 = Convert.ToInt32(Console.ReadLine());

void RandomArray (int [] array)         // Инициализация массива
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

double MediumSumArray (int [] array)        // Нахождение среднего арифметического в массиве
{
    int len = array.Length;
    double sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + array[i];
    }
    double medsum = sum / len;
    return medsum;
}

int [] numbers1 = new int [N1];
int [] numbers2 = new int [N2];

RandomArray(numbers1);
RandomArray(numbers2);

Console.WriteLine($"Первый массив: [{String.Join(",",numbers1)}]");
Console.WriteLine($"Среднее арифметическое первого массива равно: {MediumSumArray(numbers1)}");
Console.WriteLine($"Второй массив: [{String.Join(",",numbers2)}]");
Console.WriteLine($"Среднее арифметическое второго массива равно: {MediumSumArray(numbers2)}");

double count = 0;

if (MediumSumArray(numbers1) > MediumSumArray(numbers2))        // Сравнение средних арифметических и нахождение разницы
{
    count = Math.Round(MediumSumArray(numbers1) - MediumSumArray(numbers2), 0);
}
else 
{
    count = Math.Round(MediumSumArray(numbers2) - MediumSumArray(numbers1), 0);
}
Console.WriteLine($"Разница между средними арифметическими: {count}");

int[] b = new int[10]; 

void ConvertNum10ToNum2 (int num)                       // Перевод в двоичное число
{
    for (int i = 0; num >= 1; i++)                    // Деление на 2
        {
            int a = Convert.ToInt32(num) % 2;
            b[i] = a;
            num = num / 2;
        }
    for (int j = (b.Length - 1); j >= 0; j--)           // Разворот массива
            {
                Console.Write(b[j]);
            }
}

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

Console.WriteLine();
ConvertNum10ToNum2(Convert.ToInt32(count));
