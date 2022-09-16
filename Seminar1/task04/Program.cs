// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// задача №3, но решенная методом Switch

Console.Clear();

Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
      Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Неправильный ввод. Введите число от 1 до 7");
        break;
}