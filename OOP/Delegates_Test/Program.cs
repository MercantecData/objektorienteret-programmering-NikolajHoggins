using System;
using Delegates_Library;
namespace Delegates_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateContainer.del();
            Console.WriteLine(DelegateContainer.floatDel());
            DelegateContainer.intakeDel("yeetus", "deletus", "the fetus");

        }
    }
}