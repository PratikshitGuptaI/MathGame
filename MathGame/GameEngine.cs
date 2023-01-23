using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {

        internal static void AdditionGame(GameType message)
        {
            Console.WriteLine($"{message} Game is Added");
            var random = new Random();
            int score = 0;
            int firstnumber;
            int secondnumber;
            int total = 5;
            for (int i = 0; i < total; i++)
            {
                firstnumber = random.Next(1, 9);
                secondnumber = random.Next(1, 9);
                Console.WriteLine($"{firstnumber} + {secondnumber}");
                var result = Console.ReadLine();
                result=Helpers.ValidateResult(result);
                if (int.Parse(result) == (firstnumber + secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
                else Console.WriteLine("Incorrect Re!");

                if (i == 4)
                    Console.Clear(); Console.WriteLine($"Game Over.Your Final Score is {score} out of {total};If want to play more,Press any key.....");
            }
            Helpers.AddToHistory(score,message);
        }
        internal static void SubtractionGame(GameType message)
        {
            Console.WriteLine($"{message} Game is Added");
            var random = new Random();
            int total = 5;
            int score = 0;
            int firstnumber;
            int secondnumber;

            for (int i = 0; i < 5; i++)
            {
                firstnumber = random.Next(1, 9);
                secondnumber = random.Next(1, 9);
                Console.WriteLine($"{firstnumber} - {secondnumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == (firstnumber - secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
                else Console.WriteLine("Incorrect Re!");

                if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of {total};If want to play more,Press any key.....");
            }
            Helpers.AddToHistory(score, message);
        }
        internal static void MultiplicationGame(GameType message)
        {
            Console.WriteLine($"{message} Game is Added");
            var random = new Random();
            int score = 0;
            int total = 5;
            int firstnumber;
            int secondnumber;

            for (int i = 0; i < 5; i++)
            {
                firstnumber = random.Next(1, 9);
                secondnumber = random.Next(1, 9);
                Console.WriteLine($"{firstnumber} X {secondnumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == (firstnumber * secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
                else Console.WriteLine("Incorrect Re!");

                if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of {total} ;If want to play more,Press any key.....");
            }
            Helpers.AddToHistory(score, message);
        }
        internal static void DivisionGame(GameType message)
        {
            Console.WriteLine($"{message} Game is Added");
            int score = 0;
            var total = 5;

            for (int i = 0; i < total; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstnumber = divisionNumbers[0];
                var secondnumber = divisionNumbers[1];

                Console.WriteLine($"{firstnumber} / {secondnumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == (firstnumber / secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
                else Console.WriteLine("Incorrect Re!");

                if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of  {total};If want to play more,Press any key.....");

            }
            Helpers.AddToHistory(score, message);

            /*var random = new Random();
            int score = 0;
            int firstnumber;
            int secondnumber;

            for (int i = 0; i < 5; i++)
            {
                firstnumber = random.Next(1, 9);
                secondnumber = random.Next(1, 9);
                Console.WriteLine(message);
                Console.WriteLine($"{firstnumber} / {secondnumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == (firstnumber / secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
                else Console.WriteLine("Incorrect Re!");

                if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score}");
            }*/
        }

    }
}
