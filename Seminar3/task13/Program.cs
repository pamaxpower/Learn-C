// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер координатной четверти (1,2,3 или 4): ");
int quarter = int.Parse(Console.ReadLine());

void FindArgXY(int quarter)                             // Метод нахождения диапазона возможных координат точки, зная ее четверть
{
    if (quarter == 1) {
        Console.WriteLine("Значения x > 0, y > 0");
    } else if (quarter == 2) {
        Console.WriteLine("Значения x < 0, y > 0");
    } else if (quarter == 2) {
        Console.WriteLine("Значения x < 0, y < 0");
    } else if (quarter == 4) {
        Console.WriteLine("Значения x > 0, y < 0");
    } else {
        Console.WriteLine("Будь внимательнее. Просили ввести числа 1,2,3,4");
    }
}

FindArgXY(quarter);

/*
Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt16(Console.ReadLine());

switch (num)
    {
        case 1:
            Console.WriteLine("1 четверьть, диапазон X∈[0;+∞), Y∈[0;+∞)");
            break;
        case 2:
            Console.WriteLine("2 четверьть, диапазон X∈(-∞;0], Y∈[0;+∞)");
            break;
        case 3:
            Console.WriteLine("3 четверьть, диапазон X∈(-∞;0], Y∈(-∞;0]");
            break;
        case 4:
            Console.WriteLine("4 четверьть, диапазон X∈[0;+∞), Y∈(-∞;0]");
            break;
        default:
            Console.WriteLine("Вы ввели неверное число");
            break;
}
*/
