namespace School_Library
{
    public class Teacher : Person
    {
        private Salary salary;
        public Teacher(string name, int age, Salary salary)
        {
            this.name = name;
            this.salary = salary;
            this.age = age;
        }

        public Salary GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(Salary salary)
        {
            this.salary = salary;
        }
    }
}