using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Enter your name");
var name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

Menu(name, date);


void Menu(string? name, DateTime date)
{
    Console.WriteLine("------------------------");
    Console.WriteLine($"Hello {name.ToUpper()},Today is {date.DayOfWeek}.So today we are going to play a game");
    var isGameOn = true;
    do
    {
    Console.WriteLine("Select any of the operation of game");
    Console.WriteLine("Below is the list:" +
        "A:Addition," +
        "S:Subtraction," +
        "M:Multiplication," +
        "D:Division,Q:Quit");
    Console.WriteLine("------------------------");

    var gameSelected = Console.ReadLine();
    switch (gameSelected.Trim().ToLower())
    {
        case "a": AdditionGame("Addition"); break;
        case "s": SubtractionGame("Subtraction"); break;
        case "m": MultiplicationGame("Multiplication"); break;
        case "d": DivisionGame("Division"); break;
        case "q": Environment.Exit(1); break;
        default:
            Console.WriteLine("Right something worthwhile braahh!!");
            break;
    }

    } while (isGameOn);
}
void AdditionGame(string message)
{
    Console.WriteLine("Addition Game is Added");
    var random = new Random();
    int score = 0;
    int firstnumber;
    int secondnumber;
    int total = 5;
    for (int i = 0; i < total; i++)
    {
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);
        Console.WriteLine(message);
        Console.WriteLine($"{firstnumber} + {secondnumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == (firstnumber + secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
        else Console.WriteLine("Incorrect Re!");

        if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of {total}");
    }
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Subtraction Game is Added");
    var random = new Random();
    int total = 5;
    int score = 0;
    int firstnumber;
    int secondnumber;

    for (int i = 0; i < 5; i++)
    {
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);
        Console.WriteLine(message);
        Console.WriteLine($"{firstnumber} - {secondnumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == (firstnumber - secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
        else Console.WriteLine("Incorrect Re!");

        if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of {total}");
    }
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Multiplication Game is Added");
    var random = new Random();
    int score = 0;
    int total = 5;
    int firstnumber;
    int secondnumber;

    for (int i = 0; i < 5; i++)
    {
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);
        Console.WriteLine(message);
        Console.WriteLine($"{firstnumber} X {secondnumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == (firstnumber * secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
        else Console.WriteLine("Incorrect Re!");

        if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of {total}");
    }
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Division Game is Added");
    int score = 0;
    var total = 5;

    for (int i = 0; i < total; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstnumber = divisionNumbers[0];
        var secondnumber = divisionNumbers[1];

        Console.WriteLine($"{firstnumber} / {secondnumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == (firstnumber / secondnumber)) { Console.WriteLine("Correct Bruh,One point to Gryffindor"); score++; }
        else Console.WriteLine("Incorrect Re!");

        if (i == 4) Console.WriteLine($"Game Over.Your Final Score is {score} out of  {total}");

    }

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

int[] GetDivisionNumbers()
{
    var random = new Random();
    var result = new int[2];
    var firstnumber = random.Next(1,99);
    var secondnumber = random.Next(1,99);
    while(firstnumber%secondnumber != 0)
    {
        firstnumber = random.Next(1, 99);
        secondnumber = random.Next(1, 99);
    }
    result[0] = firstnumber;
    result[1] = secondnumber;
    return result;
}