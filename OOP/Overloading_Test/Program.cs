using System;
using Overloading_Library;

namespace Overloading_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathClass.Add(2, 2));
            Console.WriteLine(MathClass.Add(2.0f, 2.0f));
            Console.WriteLine(MathClass.Add("2", "2"));

            Console.WriteLine(MathClass.Divide("24", "9"));
        }
    }
}
