using System;
namespace PersonRegister_Library
{
    public class Company
    {
        private string name;
        private string address;
        private int age;

        public Company(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
