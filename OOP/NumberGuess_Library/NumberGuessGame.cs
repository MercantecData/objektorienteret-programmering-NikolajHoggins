using System;
using System.Threading.Tasks;

namespace NumberGuess_Library
{
    public static class NumberGuessGame
    {
        public static int GenerateNumber(int minValue, int maxValue)
        {
            Random rand = new Random();
            return rand.Next(minValue, maxValue);
        }
        public static Task Timer(int secondsToGuess)
        {
            Task task = new Task(() =>
            {
                for (int i = 0; i < secondsToGuess; i++)
                {
                    Task.Delay(1000).Wait();
                    Console.WriteLine($"You have {secondsToGuess-i} seconds left to guess!        ");
                }    
            });
            
            task.Start();
            
            return task;
        }
    }
}