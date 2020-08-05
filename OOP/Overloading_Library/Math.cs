using System;

namespace Overloading_Library
{
    public class MathClass
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static int Add(string a, string b)
        {
            return parseNum(a) + parseNum(b);
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        public static int Subtract(string a, string b)
        {
            return parseNum(a) - parseNum(b);
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        public static int Multiply(string a, string b)
        {
            return parseNum(a) * parseNum(b);
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }
        public static int Divide(string a, string b)
        {
            return parseNum(a) / parseNum(b);
        }
        
        private static int parseNum(string num)
        {
            bool isParsable = Int32.TryParse(num, out int number);

            if (isParsable)
                return(number);
            else
            {
                Console.WriteLine("[Error] Could not parse string to number.");
                return -1;
            }
        }
    }
}
