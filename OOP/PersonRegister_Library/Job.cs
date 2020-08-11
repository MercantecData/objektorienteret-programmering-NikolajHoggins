using System;
namespace PersonRegister_Library
{
    public class Job
    {
        private string title;
        private Salary salary;
        private Company company;

        public Job(string title, Salary salary, Company company)
        {
            this.title = title;
            this.salary = salary;
            this.company = company;
        }
    }
}
