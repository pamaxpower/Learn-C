/*
Дан текст. В тексте нужно заменить все пробелы черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "С".
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели вы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского корля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // =r

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;                           // Длина строки(текста)
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";   // Если проверяемый символ совпадает с заданным старым, то программа меняет его на новый
        else result = result + $"{text[i]}";                       // если нет, то символ перезаписывается
    }
    return result;
}
string newText = Replace (text, ' ', '|');              // Необходимо использовать только '', c "" код не работает
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();



