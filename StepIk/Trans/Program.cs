// Написать программу для перевода десла из десятичной системы в двоичную

Console.Clear();

Console.WriteLine("Введите целое число: ");
int num10 = Convert.ToInt32(Console.ReadLine());
 
int[] b = new int[5]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
for (int i = 0; num10 >= 1; i++)
    {
        int a = num10 % 2;
        b[i] = a;
 
        num10 = num10 / 2;
 
        Console.Write(a);
    };
 
    Console.WriteLine();
    Console.WriteLine($"индекс {b[2]}");

 
    for (int j = (b.Length - 1); j >= 0; j--)
        {
            Console.Write(b[j]);
        }
 
        Console.ReadKey();










/*
int [] mas = new int [10];

for (int i = 0; num >= 1; i++)
{
    int a = num % 2;
    num = num / 2;
    for (int index = 0; index < mas.Length; index++)
    {
        mas[index] = a;
        break;
    }

    /*string str = a.ToString();
    int[] b = new int[mas.Length];
    for (int j = 0; j < mas.Length; j++)
    {
        b[j] = int.Parse(str[j].ToString());
    }
    Console.Write($"{String.Join(",",b)}");
} 
    Console.WriteLine(mas);*/
/*
int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };
             
int n = numbers.Length; // длина массива
int k = n / 2;          // середина массива
int temp;               // вспомогательный элемент для обмена значениями
for(int i=0; i < k; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[n - i - 1];
    numbers[n - i - 1] = temp;
}
foreach(int i in numbers)
{
    Console.Write($"{i} \t");
}
*/
