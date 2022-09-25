/* Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов 
и вывести на экран те (тот), где чаще всего встречается введённая буква.
Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"
*/

Console.Clear();

string[] city = {"Москва", "Тюмень", "Новосибирск", "Санкт-Петербург", "Краснодар", "Казань"};

Console.WriteLine("Введите букву русского алфавита: ");
string letter = Convert.ToString(Console.ReadLine());



int index = 0;
for (index = 0; index < city.Length; index++)
{
    if (city[index].Contains(letter.ToLower()))
    {
        // int count = city[index].ToCharArray().Where(i => i == '5').Count();
        // Console.WriteLine(count);
        
        Console.WriteLine($"В слове {city[index]} есть буква {letter}");
    } 
    else
        Console.WriteLine($"В слове {city[index]} нет буквы {letter}");
}
    
