// Пример цикла for

string Method4(int count, string text)                  
{
    
    string result = string.Empty;   
    for (int i = 0; i < count; i++)               // Инициализация счетчика, условие, инкремент(увеличение счетчика)     
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "текст ");
Console.WriteLine(res);