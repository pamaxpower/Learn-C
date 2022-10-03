
Console.Clear();

string[] inputCities = new string[] { "Москва", "Тюмень", "Новосибирск", "Ижевск", "Краснодар" };

Console.WriteLine();

Console.Write("Введите букву: ");

string inputLetter = Console.ReadLine();

PrintCitiesWithMaxCountInputLetter(inputCities,GetMaxCountLetterByCities(inputCities, inputLetter));

int[] GetMaxCountLetterByCities(string [] cities, string letter)
{

    int[] countsInputLetterByCities = new int[cities.Length];

    string city = string.Empty;

    int countLetter = 0;

    for (int i = 0; i < cities.Length; i++)
    {
        countLetter = 0;
        city = cities[i];

        for (int j = 0; j < city.Length; j++)
        {
            if (city[j].ToString().ToLower() == letter.ToLower())
            {
                countLetter++;
            }
        }
        countsInputLetterByCities[i] = countLetter;
    }
    return countsInputLetterByCities;
}

void PrintCitiesWithMaxCountInputLetter(string[] cities, int[] countLettersByCities)
{
    if (countLettersByCities.Max() != 0)
    {
        for (int i = 0; i < cities.Length; i++)
        {
            if (countLettersByCities[i] == countLettersByCities.Max()) Console.Write($"{cities[i]} ");
        }
    }
    else
    Console.WriteLine("Данная буква отсутствует в названии городов!");
}