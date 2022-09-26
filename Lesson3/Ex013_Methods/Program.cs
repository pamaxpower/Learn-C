/* Общий вид: 

ВозращаемыйТипДанныч ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
{
    Тело Метода
    return ЗначениеСоответствующееВозращаемомуТипуДанных
}
*/


// Вид 1

void Method1()                                          // Выводит на экран какое-то сообщение
{
    Console.WriteLine("Автор текста: ");
}
// Method1();                                           // Команда вызова метода



// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)                    // В теле метода используем эти аргументы, они и будут ключевыми при вызове метода
{
    int  i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);                    // Вывести на экран 4 раза слово "текст"
// Method21(count: 4, msg: "новый текст");              // При указывании агрумента их можно писать в любом порядке


//Вид 3

int Method3()                                           // Указываем тип данных, которые мы хотим получить: int
{
    return DateTime.Now.Year;                           // Произошла какая-то работа в теле фунции
}
int year = Method3();                                   // В эту переменную мы положили результат этой работы
// console.WriteLine(year);                                // Вывод результата

// Вид 4

string Method4(int count, string text)                  // Переименовать переменную можно нажанием F2, тогда она изменится везде
{
    int i = 0;
    string result = string.Empty;                       // Пустая строка или " "
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "текст ");
Console.WriteLine(res);

