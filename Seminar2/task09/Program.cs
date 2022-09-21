// // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int num_max = (num1 > num2)?num1:num2 - тернарный оператор. Всю строку можно расписать как if else
//               условие       if   else


// Метод проверяющий на null или пустое - 1:36:49 

Console.Clear();

Console.WriteLine("Введите первое число: ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB  == 0)
{
    Console.WriteLine($"Число {numberA} кратно числу {numberB}");
}
else Console.WriteLine($"Число {numberA} некратно числу {numberB}, остаток от деления {numberA % numberB}");


// string? a = (Console.ReadLine());
// string? b = (Console.ReadLine());

// if (int.Parse(a) % int.Parse(b) == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
//     Console.WriteLine($"Некратно, остаток от деления: {int.Parse(a) % int.Parse(b)}");