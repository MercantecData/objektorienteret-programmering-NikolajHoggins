using System;
using System.Threading.Tasks;
using NumberGuess_Library;

namespace NumberGuess_Test
{
    class Program
    {
        private static bool isGameOver;
        private static int hiddenNumber;
        
        static void Main(string[] args)
        {
            PrintIntroduction();
            
            Task task = NumberGuessGame.Timer(10);
            bool isGameOver = false;
            
            task.ContinueWith((task) => isGameOver = true);

            int guess = -1;
            while (!isGameOver)
            {
                string guessStr = Console.ReadLine();
                try
                {
                    guess = Int32.Parse(guessStr);
                }
                catch (Exception e)
                {
                }

                if (guess == hiddenNumber)
                {
                    isGameOver = true;
                }
                else
                {
                    Console.WriteLine("Wrong! try again");
                }
            }

            Console.Clear();
            if (guess == hiddenNumber)
            {
                Console.WriteLine("Lmao you are good, you won!");    
            }
            else
            {
                Console.WriteLine("Lmao you ran out of time and you suck, you lost.");
            }
            Console.WriteLine($"BTW the number was {hiddenNumber}");

            
        }
        
        private static void PrintIntroduction()
        {
            Console.WriteLine("Hello and welcome to my number guessing game!");
            int maxNum = SetupGame();
            Console.Clear();
            Console.WriteLine($"You will have 10 seconds to guess a number between 1-{maxNum}");
            Console.WriteLine("Press enter to begin...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Start guessing!");
        }

        private static int SetupGame()
        {
            int difficulty = 0;
            while (!(difficulty > 0 && difficulty < 6))
            {
                Console.WriteLine("Let's star off by setting the difficulty. Choose a difficulty between 1-5");
                try
                {
                    difficulty = Int32.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    difficulty = 0;
                }
            }

            int maxNum = 11 * difficulty;
            hiddenNumber = NumberGuessGame.GenerateNumber(1, maxNum);
            return maxNum - 1;

        }
    }
}