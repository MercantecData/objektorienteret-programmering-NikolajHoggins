using System;
using System.Collections.Generic;
namespace PersonRegister_Library
{
    public class Register
    {
        private Dictionary<string, Person> people = new Dictionary<string, Person>();
        private List<LogEntry> log = new List<LogEntry>();

        ///<summary>
        /// Add person to the dictionary by whole object.
        ///</summary>
        public void AddPerson(Person person)
        {
            this.log.Add(new LogEntry("Added person " + person.GetName()));
            this.people[person.GetName()] = person;
        }

        ///<summary>
        /// Returns whole dictionary of people.
        ///</summary>
        public Dictionary<string, Person> GetPeople()
        {
            this.log.Add(new LogEntry("Retrieved all people in register. Current people: " + this.people.Count));
            return this.people;
        }

        ///<summary>
        /// Returns random Person object from the people dictionary.
        ///</summary>
        public Person GetPerson()
        {
            List<string> keyList = new List<string>(this.people.Keys);

            Random rand = new Random();
            string randomKey = keyList[rand.Next(keyList.Count)];

            this.log.Add(new LogEntry("Retrieved random person, got: " + this.people[randomKey].GetName()));

            return this.people[randomKey];

        }

        ///<summary>
        /// Returns a Person object by looking for name of person.
        ///</summary>
        public Person GetPerson(string name)
        {

            this.log.Add(new LogEntry("Retrieved person: " + name));

            return this.people[name];

        }

        ///<summary>
        /// Removes person given.
        ///</summary>
        public bool RemovePerson(string name)
        {
            this.log.Add(new LogEntry("Removed person: " + name));
            this.people.Remove(name);
            return false;
        }

        ///<summary>
        /// Returns a list of LogEntries that contain all actions and timestamps of those actions.
        ///</summary>
        public List<LogEntry> GetLog()
        {
            return this.log;
        }
    }
}
