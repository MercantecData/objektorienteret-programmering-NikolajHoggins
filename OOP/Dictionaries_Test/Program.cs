using System;
using Dictionaries_Library;
using System.Threading;
namespace Dictionaries_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryStore dictionaryStore = new DictionaryStore();

            dictionaryStore.numbers.Add("one", 1);
            dictionaryStore.numbers.Add("two", 2);
            dictionaryStore.numbers.Add("three", 3);
            dictionaryStore.numbers.Add("four", 4);
            dictionaryStore.numbers.Add("five", 5);
            dictionaryStore.numbers.Add("six", 6);
            dictionaryStore.numbers.Add("seven", 7);
            dictionaryStore.numbers.Add("eight", 8);
            dictionaryStore.numbers.Add("nine", 9);
            dictionaryStore.numbers.Add("ten", 10);

            dictionaryStore.isNice.Add(1.337f, true);
            dictionaryStore.isNice.Add(1.2374f, false);
            dictionaryStore.isNice.Add(2.437f, false);
            dictionaryStore.isNice.Add(0.69f, true);
            dictionaryStore.isNice.Add(1.234f, false);
            dictionaryStore.isNice.Add(4.20f, true);
            dictionaryStore.isNice.Add(420.69f, true);
            dictionaryStore.isNice.Add(0.001f, false);
            dictionaryStore.isNice.Add(10.10f, false);
            dictionaryStore.isNice.Add(80.085f, true);


            while (true)
            {
                Console.WriteLine("Chose dictionary to look in:");
                Console.WriteLine("1) numbers");
                Console.WriteLine("2) isNice");

                char choiceChar = Console.ReadKey().KeyChar;
                int choice;

                Console.Clear();

                choice = char.IsDigit(choiceChar) ? int.Parse(choiceChar.ToString()) : 0;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a number in word form between 'one' and 'ten'");
                        string numberToCheck = Console.ReadLine().ToLower();

                        dictionaryStore.numbers.TryGetValue(numberToCheck, out int intReturn);

                        Console.WriteLine(intReturn);
                        break;
                    case 2:
                        Console.WriteLine("Enter a float, so we can check our database to see if the number is cool or not.");
                        float.TryParse(Console.ReadLine(), out float floatToCheck);
                        
                        dictionaryStore.isNice.TryGetValue(floatToCheck, out bool isNice);

                        Console.WriteLine(isNice ? "That number is VERY nice" : "Not nice bro");
                        break;
                    default:
                        Console.WriteLine("Please choose a dictionary next time");
                        break;

                }

                Thread.Sleep(2000);
                Console.Clear();
            }
            
        }
    }
}
