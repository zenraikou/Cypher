using Cypher.Models;

namespace Cypher
{
    internal class GameEngine
    {
        internal void Addition(GameType gameType)
        {
            Console.WriteLine($"<Playing {gameType} Game>");

            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 10; i++)
            {
                var roundFinished = false;
                firstNumber = random.Next(0, 999);
                secondNumber = random.Next(0, 999);

                Console.Write(
        $@"
+++++++++++++++++++++++++++++++++++++++++++++
<Round {i + 1}>
");

                Console.Write($"{firstNumber} + {secondNumber} = ");
                var answer = Console.ReadLine();

                while(string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                {
                    Console.WriteLine("Answer must be a whole number.");
                    answer = Console.ReadLine();
                }

                while (!roundFinished)
                {
                    if (int.Parse(answer) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("<Correct>");
                        score++;
                        Thread.Sleep(300);
                    }
                    else
                    {
                        Console.WriteLine("<Wrong>");
                        Thread.Sleep(300);
                    }

                    roundFinished = true;
                }

                if (i == 9)
                {
                    Helpers.ArchiveGame(gameType, score);

                    Console.WriteLine(
        $@"
=============================================
                Game Over
                Score: {score}
=============================================
");
                    Console.WriteLine("<Press 'Enter' key to show Game Menu>");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        internal void Subtraction(GameType gameType)
        {
            Console.WriteLine($"<Playing {gameType} Game>");

            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 10; i++)
            {
                var roundFinished = false;
                firstNumber = random.Next(0, 999);
                secondNumber = random.Next(0, 999);

                Console.Write(
        $@"
---------------------------------------------
<Round {i + 1}>
");

                Console.Write($"{firstNumber} - {secondNumber} = ");
                var answer = Console.ReadLine();

                while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                {
                    Console.WriteLine("Answer must be a whole number.");
                    answer = Console.ReadLine();
                }

                while (!roundFinished)
                {
                    if (int.Parse(answer) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("<Correct>");
                        score++;
                        Thread.Sleep(300);
                    }
                    else
                    {
                        Console.WriteLine("<Wrong>");
                        Thread.Sleep(300);
                    }

                    roundFinished = true;
                }

                if (i == 9)
                {
                    Helpers.ArchiveGame(gameType, score);

                    Console.WriteLine(
        $@"
=============================================
                Game Over
                Score: {score}
=============================================
");
                    Console.WriteLine("<Press 'Enter' key to show Game Menu>");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        internal void Multiplication(GameType gameType)
        {
            Console.WriteLine($"<Playing {gameType} Game>");

            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 10; i++)
            {
                var roundFinished = false;
                firstNumber = random.Next(0, 999);
                secondNumber = random.Next(0, 999);

                Console.Write(
        $@"
*********************************************
<Round {i + 1}>
");

                Console.Write($"{firstNumber} * {secondNumber} = ");
                var answer = Console.ReadLine();

                while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                {
                    Console.WriteLine("Answer must be a whole number.");
                    answer = Console.ReadLine();
                }

                while (!roundFinished)
                {
                    if (int.Parse(answer) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("<Correct>");
                        score++;
                        Thread.Sleep(300);
                    }
                    else
                    {
                        Console.WriteLine("<Wrong>");
                        Thread.Sleep(300);
                    }

                    roundFinished = true;
                }

                if (i == 9)
                {
                    Helpers.ArchiveGame(gameType, score);

                    Console.WriteLine(
        $@"
=============================================
                Game Over
                Score: {score}
=============================================
");
                    Console.WriteLine("<Press 'Enter' key to show Game Menu>");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        internal void Division(GameType gameType)
        {
            Console.WriteLine($"<Playing {gameType} Game>");

            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 10; i++)
            {
                var roundFinished = false;
                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];

                Console.Write(
        $@"
/////////////////////////////////////////////
<Round {i + 1}>
");

                Console.Write($"{firstNumber} / {secondNumber} = ");
                var answer = Console.ReadLine();

                while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
                {
                    Console.WriteLine("Answer must be a whole number.");
                    answer = Console.ReadLine();
                }

                while (!roundFinished)
                {
                    if (int.Parse(answer) == firstNumber / secondNumber)
                    {
                        Console.WriteLine("<Correct>");
                        score++;
                        Thread.Sleep(300);
                    }
                    else
                    {
                        Console.WriteLine("<Wrong>");
                        Thread.Sleep(300);
                    }

                    roundFinished = true;
                }

                if (i == 9)
                {
                    Helpers.ArchiveGame(gameType, score);

                    Console.WriteLine(
        $@"
=============================================
                Game Over
                Score: {score}
=============================================
");
                    Console.WriteLine("<Press 'Enter' key to show Game Menu>");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
