using System;
using System.Collections.Generic;
namespace PersonRegister_Library
{
    public class Register
    {
        public List<Person> people = new List<Person>();
        public List<LogEntry> log = new List<LogEntry>();

        public void AddPerson(Person person)
        {
            this.log.Add(new LogEntry("Added person " + person.name));
            this.people.Add(person);
        }

    }
}
