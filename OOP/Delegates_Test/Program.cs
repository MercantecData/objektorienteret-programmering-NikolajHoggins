using System;
using Delegates_Library;
using Overloading_Library;
    
namespace Delegates_Test
{
    class Program
    {
        public delegate int AddDel(int a, int b);
        public delegate float AddFloatDel(float a, float b);

        static void Main(string[] args)
        {
            DelegateContainer.del();
            Console.WriteLine(DelegateContainer.floatDel());
            DelegateContainer.intakeDel("yeetus", "deletus", "the fetus");

            
            
            
            //Bonus task:
            AddDel addDel = MathClass.Add;
            AddFloatDel addFloatDel = MathClass.Add;
            
            Console.WriteLine(addDel(1, 4));
            Console.WriteLine(addFloatDel(1.5f, 4.2f));
            

        }
        
        
    }
}