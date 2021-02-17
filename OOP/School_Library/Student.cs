using System.Collections.Generic;

namespace School_Library
{
    public class Student : Person
    {
        private Dictionary<string, Grade> grades = new Dictionary<string, Grade>();
        
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Dictionary<string, Grade> GetGrades()
        {
            return this.grades;
        }
        
        public void AddGrade(Grade grade)
        {
            this.grades[grade.GetSubject()] = grade;
        }
    }
}