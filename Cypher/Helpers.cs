using Cypher.Models;

namespace Cypher
{
    internal class Helpers
    {
        static List<Game> games = new();

        internal static void ArchiveGame(GameType gameType, int score)
        {
            games.Add(new Game
            {
                Type = gameType,
                Score = score
            });
        }

        internal static void GetArchivedGames()
        {
            Console.WriteLine("<Game History>");
            Console.WriteLine("================================================================================");

            foreach (var game in games)
            {
                Console.WriteLine($"<{game.Date.ToLongTimeString()} {game.Date.ToLongDateString()}> {game.Type} Game: {game.Score}pts");
            }
            Console.WriteLine("================================================================================");
            Console.WriteLine("<Press 'Enter' key to show Game Menu>");
            Console.ReadLine();
            Console.Clear();
        }
        internal static string GetName()
        {
            Console.WriteLine("<Enter Game Name>");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name.Trim()))
            {
                Console.WriteLine("Name is required.");
                Thread.Sleep(300);
                Console.Clear();

                Console.WriteLine("<Enter Game Name>");
                name = Console.ReadLine();
            }

            Thread.Sleep(300);
            Console.Clear();

            return name;
        }

        internal static int[] GetDivisionNumbers()
        {
            var divisionNumbers = new int[2];
            var random = new Random();

            do
            {
                divisionNumbers[0] = random.Next(1, 999);
                divisionNumbers[1] = random.Next(1, 999);
            } while (divisionNumbers[0] % divisionNumbers[1] != 0);

            return divisionNumbers;
        }
    }
}
