// Чтение кнопок на клавиатуре

Console.Clear();
System.Console.WriteLine("turn");
ConsoleKey consolekey = Console.ReadKey().Key;

switch (consolekey)
{
    case ConsoleKey.RightArrow:

        for (int i = 0; i < 5; i++)                             // 5 ходов
        {                                                       // Ход = 1 поворот(только вправо). Как сделать чтобы поворы чередовались? Рекурсия? 1 поворот = 1 клетка на поле вниз.
            //System.Console.WriteLine("Code");
            ConsoleKey key = Console.ReadKey().Key;             
            if (key != ConsoleKey.Enter)                        // Пока жму клавишу Enter, выполняется действие (5 ходов)
            {
                break;      // конец, если нажал не enter
            }
            System.Console.WriteLine(i + " Тук-тук");
        }
    break;          // конец кейса

    // case ConsoleKey.LeftArrow:
    // System.Console.WriteLine("Так-так");
    // break;
    // case ConsoleKey.UpArrow:
    // System.Console.WriteLine("Ток-ток");
    // break;
    // case ConsoleKey.DownArrow:
    // System.Console.WriteLine("Тик-тик");
    // break;
    default:
    break;
}