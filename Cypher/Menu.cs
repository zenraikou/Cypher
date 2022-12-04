using Cypher.Models;

namespace Cypher
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        DateTime date = DateTime.UtcNow;

        internal void Show(string name)
        {
            var inGame = true;

            var greetings =
$@">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Greetings, {name}.
It's {$"{date.ToLongTimeString()} {date.ToLongDateString()}"}.
Good to see you working for improvement!
<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";

            Console.WriteLine(greetings);
            Console.WriteLine("<Press 'Enter' key to show Game Menu>");
            Console.ReadLine();
            Console.Clear();

            var cypherGames =
$@">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
<Cypher Games>
A > Addition
S > Subtraction
M > Multiplication
D > Division
H > Game History
Q < Quit Game
<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";

            while (inGame)
            {
                Console.WriteLine(cypherGames);
                Console.WriteLine("<Choose Your Game>");
                var gameType = Console.ReadLine();

                switch (gameType.ToLower().Trim())
                {
                    case "a":
                        Console.Clear();
                        gameEngine.Addition(GameType.Addition);
                        break;
                    case "s":
                        Console.Clear();
                        gameEngine.Subtraction(GameType.Subtraction);
                        break;
                    case "m":
                        Console.Clear();
                        gameEngine.Multiplication(GameType.Multiplication);
                        break;
                    case "d":
                        Console.Clear();
                        gameEngine.Division(GameType.Division);
                        break;
                    case "h":
                        Console.Clear();
                        Helpers.GetArchivedGames();
                        break;
                    case "q":
                        inGame = false;
                        Console.Clear();
                        Console.Write($"<Goodbye, {name}>");
                        Thread.Sleep(3000);
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        Thread.Sleep(300);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
