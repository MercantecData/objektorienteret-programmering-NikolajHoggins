using System;

namespace PersonRegister_Library
{
    public class Person
    {
        public string name;
        public int age;
        public string address;
        public Job job;

        public Person(string name, int age, string address, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.address = address;
        }

        //This method will quit your job, but as you will lose your income stream, you will also lose your house
        public void quitJob()
        {
            this.job = default(Job);
            this.address = default(string);
        }
    }
}
