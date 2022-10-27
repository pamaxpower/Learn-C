// Цикл в цикле по листу. Не могу задать Лист

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main (string[] args)
        {
            var gamesInfo = GetGamesInfo();

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");

                for (int j = 0; j < gamesInfo.Games.Count; j++)
                {
                    Console.WriteLine($"{gamesInfo[i].Games[j].Name}:");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static List<GameInfo> GetGamesInfo()
        {
            return new List<GameInfo>()
            {
                new GameInfo()
                {
                    TypeOfGame = GameType.RPG,
                    Games = new List<Game>()
                    {
                        new Game(){Name = "1"},
                        new Game(){Name = "2"},
                        new Game(){Name = "3"}
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Shooter,
                    GetGamesInfo = new List<Game>()
                    {
                        new Game(){Name = "4"},
                        new Game(){Name = "5"},
                        new Game(){Name = "6"}
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Strategy,
                    GetGamesInfo = new List<Game>()
                    {
                        new Game(){Name = "7"},
                        new Game(){Name = "8"},
                        new Game(){Name = "9"}
                    }
                }
            };
        }
//     }
// }

List<Person> TT = new List<Person>;
// {
//     new Person("Tom"),
//     new Person("Bob")
// };
    List<T> myList = new List<T>();
    T instance = new T();