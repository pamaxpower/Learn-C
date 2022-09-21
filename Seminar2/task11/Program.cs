// Метод проверяющий на null или пустое 

string? inputString = Console.ReadLine();
int a = 0;
    if (String.IsNullOrEmpty(inputString))
    {
        a = Convert.ToInt32(inputString);
    }