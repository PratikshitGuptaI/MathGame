using MathGame.Models;

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine= new();
        Helpers helper = new();
        internal void GameMenu(string? name, DateTime date)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Hello {name.ToUpper()},Today is {date.DayOfWeek}.So today we are going to play a game");
            var isGameOn = true;
            do
            {
                Console.WriteLine("Select any of the operation of game");
                Console.WriteLine("Below is the list:" +
                    "V:View Previous Games" +
                    "A:Addition," +
                    "S:Subtraction," +
                    "M:Multiplication," +
                    "D:Division,Q:Quit");
                Console.WriteLine("------------------------");

                var gameSelected = Console.ReadLine();
                switch (gameSelected.Trim().ToLower())
                {
                    case "v": Helpers.GetGames(); break;
                    case "a": GameEngine.AdditionGame(GameType.Addition); break;
                    case "s": GameEngine.SubtractionGame(GameType.Subtraction); break;
                    case "m": GameEngine.MultiplicationGame(GameType.Multiplication); break;
                    case "d": GameEngine.DivisionGame(GameType.Division); break;
                    case "q": isGameOn = false; break;
                    default:
                        Console.WriteLine("Right something worthwhile braahh!!");
                        break;
                }

            } while (isGameOn);
        }

    }
}
