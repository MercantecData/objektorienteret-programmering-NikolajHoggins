using System;
using Delegates_Library;
using Overloading_Library;
    
namespace Delegates_Test
{
    class Program
    {
        public delegate int AddDel(int a, int b);
        public delegate float AddFloatDel(float a, float b);

        public delegate int LambdaTwoTimes(int a);
        public delegate float LambdaFloatSum(float a, float b, float c);
        public delegate string LambdaString();
        
        static void Main(string[] args)
        {
            /*
             * Deletages Tasks
             */
            DelegateContainer.del();
            Console.WriteLine(DelegateContainer.floatDel());
            DelegateContainer.intakeDel("yeetus", "deletus", "the fetus");
                
            //Bonus task:
            AddDel addDel = MathClass.Add;
            AddFloatDel addFloatDel = MathClass.Add;
            
            Console.WriteLine(addDel(1, 4));
            Console.WriteLine(addFloatDel(1.5f, 4.2f));
            
            
            /*
             * Lambda Tasks
             */
            LambdaTwoTimes lambdaTwoTimes = (a) => a * 2;
            Console.WriteLine(lambdaTwoTimes(4));

            LambdaFloatSum lambdaFloatSum = (a, b, c) => a + b + c;
            Console.WriteLine(lambdaFloatSum(2.4f,2.6f,7.3f));

            LambdaString lambdaString = () => "Hello world";
            Console.WriteLine(lambdaString());
            
        }
        
        
    }
}