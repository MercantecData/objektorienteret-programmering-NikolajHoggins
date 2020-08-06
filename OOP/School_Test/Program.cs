using System;
using System.Linq;
using School_Library;
namespace School_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Mercantec");
            AddStudents(school);
            AddTeachers(school);
            AddGroups(school);
            AddStudentsToGroups(school);

            school.GetTeacherByName("asfasg");
            
            Console.WriteLine(school.GetStudentByName("sdasd Hoggins"));
            
            //Change name of Nikolaj Hoggins
            Student hoggins = school.GetStudentByName("Nikolaj Hoggins");
            hoggins.SetName("Nillaj Hoggins");
            Console.WriteLine(hoggins.GetName());


            ////Tests
            //FunctionTest.TestRemovingTeacher(school);
            //FunctionTest.TestPrintingStudentsFromGroup(school.GetGroups()["Pizza Time"]);
            //FunctionTest.TestPrintingEmployees(school);
        }


        static void AddStudents(School school)
        {
            school.AddStudent(new Student("Nikolaj Hoggins", 18));
            school.AddStudent(new Student("Jeppe Vad", 18));
            school.AddStudent(new Student("Oliver Nielsen", 17));
            school.AddStudent(new Student("Mike Møller", 22));
            school.AddStudent(new Student("Mike Hog", 19));
            school.AddStudent(new Student("Lil Smartguy", 12));
            school.AddStudent(new Student("Megan Fox", 34 ));
            school.AddStudent(new Student("Jennifer Lawrence", 29));
            school.AddStudent(new Student("Another Person", 18));
        }
        static void AddTeachers(School school)
        {
            school.AddTeacher(new Teacher("Guy Fieri", 54, new Salary(10.00m)));
            school.AddTeacher(new Teacher("Mads Bock", 29, new Salary(87000.00m)));
            school.AddTeacher(new Teacher("Bat Man", 42, new Salary(340000.00m)));
            school.AddTeacher(new Teacher("Peter Parker", 35, new Salary(45000.00m)));
            
        }

        static void AddGroups(School school)
        {
            var teachers = school.GetTeachers();
            school.AddGroup(new Group("Programmering H2", teachers["Mads Bock"]));
            school.AddGroup(new Group("Swag 101", teachers["Guy Fieri"]));
            school.AddGroup(new Group("Fighting Crime", teachers["Bat Man"]));
            school.AddGroup(new Group("Pizza Time", teachers["Peter Parker"]));
        }

        static void AddStudentsToGroups(School school)
        {
            school.GetGroups()["Pizza Time"].AddStudent(school.GetStudents()["Nikolaj Hoggins"]);
            school.GetGroups()["Pizza Time"].AddStudent(school.GetStudents()["Megan Fox"]);
            school.GetGroups()["Pizza Time"].AddStudent(school.GetStudents()["Jennifer Lawrence"]);
            school.GetGroups()["Programmering H2"].AddStudent(school.GetStudents()["Mike Hog"]);
            school.GetGroups()["Programmering H2"].AddStudent(school.GetStudents()["Jeppe Vad"]);
            school.GetGroups()["Programmering H2"].AddStudent(school.GetStudents()["Oliver Nielsen"]);
        }
    }
}