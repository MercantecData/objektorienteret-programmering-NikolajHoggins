using System.Collections.Generic;

namespace School_Library
{
    public class Group
    {
        private string name;
        private Teacher teacher;
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public Group(string name, Teacher teacher)
        {
            this.name = name;
            this.teacher = teacher;
        }

        public string GetName()
        {
            return this.name;
        }
        
        public void AssignTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public void RemoveTeacher()
        {
            this.teacher = default(Teacher);
        }

        /// <summary>
        /// Get teacher of group
        /// </summary>
        /// <summary>
        /// return teacher if set, else returns null
        /// </summary>
        public Teacher GetTeacher()
        {
            return teacher;
        }

        public Dictionary<string, Student> GetStudents()
        {
            return this.students;
        }

        public void AddStudent(Student student)
        {
            this.students[student.GetName()] = student;
        }
    }
}