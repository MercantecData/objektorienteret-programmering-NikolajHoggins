using System;

namespace PersonRegister_Library
{
    public class Person
    {
        private string name;
        private int age;
        private string address;
        private Job job;

        public Person(string name, int age, string address, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.address = address;
        }

        public string GetName()
        {
            return this.name;
        }
        
        //This method will quit your job, but as you will lose your income stream, you will also lose your house
        public void quitJob()
        {
            this.job = default(Job);
            this.address = default(string);
        }
    }
}
