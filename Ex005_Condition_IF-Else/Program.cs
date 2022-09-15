Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "паша")  //команда ToLower - все символы строки переводит в нижний регистр. Для того чтобы исключить ошибки на вариантах ПАша, ПаШа и тд
{
    Console.WriteLine("Привет хозяин! Готов служить тебе");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}