using MathGame;

var menu = new Menu();
Console.WriteLine("Enter your name");
var name = Console.ReadLine();
while (String.IsNullOrEmpty(name))
{
    Console.WriteLine("Name cannot be empty");
    name=Console.ReadLine();
}

DateTime date = DateTime.UtcNow;
menu.GameMenu(name, date);