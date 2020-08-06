namespace School_Library
{
    public class Person
    {
        protected string name;
        protected int age;
        
        ///<summary>
        /// Get name of person.
        ///</summary>
        public string GetName()
        {
            return this.name;
        }
        
        ///<summary>
        /// Get age of person.
        ///</summary>
        public int GetAge()
        {
            return this.age;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }
        
        public void SetAge(int newAge)
        {
            this.age = newAge;
        }
    }
}