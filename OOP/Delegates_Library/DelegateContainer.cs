using System;

namespace Delegates_Library
{
    public class DelegateContainer
    {
        public delegate void VoidDelegate();
        public delegate float FloatDelegate();
        public delegate void IntakeDelegate(string a, string b, string c);
        
        public static VoidDelegate del = () => Console.WriteLine("Ran delegate");
        public static FloatDelegate floatDel = () => 2.24f;
        public static IntakeDelegate intakeDel = (a, b, c) => Console.WriteLine($"You wrote {a} & {b} & {c}");

    }
}