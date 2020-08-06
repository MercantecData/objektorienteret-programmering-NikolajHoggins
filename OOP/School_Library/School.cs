using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    public class School
    {
        private string name;
        private Dictionary<string, Room> rooms = new Dictionary<string, Room>();
        private Dictionary<string, Student> students = new Dictionary<string, Student>();
        private Dictionary<string, Group> groups = new Dictionary<string, Group>();
        private Dictionary<string, Teacher> teachers = new Dictionary<string, Teacher>();

        public School(string name)
        {
            this.name = name;
        }
        
        ///<summary>
        /// Return name from school.
        ///</summary>
        ///<summary>
        /// returns: string
        ///</summary>
        public string GetName()
        {
            return this.name;
        }

        ///<summary>
        /// Sets name of school to given string.
        ///</summary>
        public void SetName(string name)
        {
            this.name = name;
        }
        
        
        
        // Teacher methods
        ///<summary>
        /// Get all teachers working at the school.
        ///</summary>
        ///<summary>
        /// returns: Dictionary of Teachers with names as keys.
        ///</summary>
        public Dictionary<string, Teacher> GetTeachers()
        {
            return this.teachers;
        }

        public Teacher GetTeacherByName(string name)
        {
            try
            {
                return this.teachers[name];
            }
            catch (Exception e)
            {
                return null;
            }
        }
        
        ///<summary>
        /// Get group with teacher assigned if it exists.
        ///</summary>
        ///<summary>
        /// returns: Group object if teacher is assigned to a group, else returns null.
        ///</summary>
        public Group GetTeacherGroup(Teacher teacher)
        {
            return (from entry in this.groups where entry.Value.GetTeacher() == teacher select entry.Value).FirstOrDefault();
        }
        
        ///<summary>
        /// Sets name of school to given string.
        ///</summary>
        public void AddTeacher(Teacher teacher)
        {
            this.teachers[teacher.GetName()] = teacher;
        }
        
        public void RemoveTeacher(string name)
        {
            this.GetTeacherGroup(this.teachers[name]).RemoveTeacher();
            this.teachers.Remove(name);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            var teacherToRemove = this.teachers.First(kvp => kvp.Value == teacher);
            this.GetTeacherGroup(teacher).RemoveTeacher();
            this.teachers.Remove(teacherToRemove.Key);
        }


        // Student methods
        public Dictionary<string, Student> GetStudents()
        {
            return this.students;
        }
        
        public Student GetStudentByName(string studentName)
        {
            try
            {
                return this.students[studentName];
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        
        public void AddStudent(Student student)
        {
            this.students[student.GetName()] = student;
        }
        
        
        public void RemoveStudent(string studentName)
        {
            this.students.Remove(studentName);
        }

        public void RemoveStudent(Student student)
        {
            var studentToRemove = this.students.First(kvp => kvp.Value == student);

            this.students.Remove(studentToRemove.Key);
        }
        
        
        
        
        
        // Group methods
        public Dictionary<string, Group> GetGroups()
        {
            return this.groups;
        }
        public void AddGroup(Group group)
        {
            this.groups[group.GetName()] = group;
        }
        
        public void RemoveGroup(string name)
        {
            this.groups.Remove(name);
        }

        public void RemoveGroup(Group group)
        {
            var groupToRemove = this.groups.First(kvp => kvp.Value == group);

            this.groups.Remove(groupToRemove.Key);
        }
    }
}
