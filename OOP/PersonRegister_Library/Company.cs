using System;
namespace PersonRegister_Library
{
    public class Company
    {
        public string name;
        public string address;
        public int age;

        public Company(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
