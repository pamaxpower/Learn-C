/* Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4
20 -> 7
30 -> 8
*/

Console.Clear();

Console.WriteLine("Введите радиус круга");
int r = Convert.ToInt32(Console.ReadLine());

double squareCircle = Math.PI * Math.Pow(r, 2);

// string num = Convert.ToString(Math.Round(squareCircle, 0));

int num = Convert.ToInt32(Math.Round(squareCircle, 0));
Console.WriteLine($"Площадь круга равна: {num}");

int maxnum = 0;

while (num > 0)
{
        if (maxnum < num % 10)
        maxnum = num % 10;     
        num = num / 10;
}
Console.WriteLine(maxnum);