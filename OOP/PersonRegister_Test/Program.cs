using System;
using PersonRegister_Library;

namespace PersonRegister_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();

            Person person1 = new Person("Jesper Jespersen", 21, "Hans Tausens Vej 22", new Job("Lead Dev", new Salary(55000, "DKK"), new Company("Bricksite ApS", "Normansvej 1", 10)));

            Person person2 = new Person("Rasmus Rasmussen", 10, "Randersvej 1", new Job("CEO", new Salary(120000, "EUR"), new Company("STARtUP", "yeetvej 21", 2)));

            Person person3 = new Person("JONAS Jespersen", 21, "Hans Tausens Vej 22", new Job("Lead Dev", new Salary(55000, "DKK"), new Company("Bricksite ApS", "Normansvej 1", 10)));
            register.AddPerson(person1);
            register.AddPerson(person2);
            register.AddPerson(person3);

            register.GetPeople();
            register.RemovePerson("Jesper Jespersen");
            register.GetPeople();
            register.GetPerson();
            foreach (LogEntry logEntry in register.GetLog())
            {
                Console.WriteLine(logEntry.getAction() + " : " + logEntry.getCreatedAt());
            }
        }

    }
}
