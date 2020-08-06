using System;
using School_Library;

namespace School_Test
{
    public class FunctionTest
    {

        public static void TestPrintingStudentsFromGroup(Group group)
        {
            Console.WriteLine("\n\n$$Running Test Get Students From Group$$\n\n");
            foreach (var kvp in @group.GetStudents())
            {
                Console.WriteLine("Student: " + kvp.Key);
                Console.WriteLine("Age: " + kvp.Value.GetAge());
            }
            
            Console.WriteLine("\n\nTEST DONE \n\n");
        }

        public static void TestPrintingEmployees(School school)
        {
            Console.WriteLine("\n\n$$Running Test Get Students From Group$$\n\n");
            foreach (var kvp in school.GetTeachers())
            {
                Console.WriteLine("Teacher: " + kvp.Key);
                Console.WriteLine("Age: " + kvp.Value.GetAge());
                Console.WriteLine("Salary monthly pay: " + kvp.Value.GetSalary().GetMonthlyPay());
                Console.WriteLine("Salary has been paid: " + kvp.Value.GetSalary().GetPaidStatus());
                Console.WriteLine("Group: " + school.GetTeacherGroup(kvp.Value).GetName());
                Console.WriteLine();

            }
            
            Console.WriteLine("\n\nTEST DONE \n\n");
        }
        
        public static void TestRemovingTeacher(School school)
        {
            Console.WriteLine("\n\n$$Running Test Removing Teacher$$\n\n");
            Console.WriteLine("Groups before firing teacher");
            Console.WriteLine("=================================");
            PrintGroupsWithTeacher(school);

            Console.WriteLine("\n\nRemoving Guy Fieri\n\n");
            school.RemoveTeacher("Guy Fieri");
            
            Console.WriteLine("Groups after firing teacher");
            Console.WriteLine("=================================");
            PrintGroupsWithTeacher(school);

            Console.WriteLine("\n\nTEST DONE \n\n");
           
        }

        private static void PrintGroupsWithTeacher(School school)
        {
            foreach (var kvp in school.GetGroups())
            {
                Console.WriteLine("Group: " + kvp.Value.GetName());
                if (kvp.Value.GetTeacher() != null)
                {
                    Console.WriteLine("Taught by: " + kvp.Value.GetTeacher().GetName());    
                }
                else
                {
                    Console.WriteLine("No Teacher in this group");
                }
                
            }
        }
    }
}