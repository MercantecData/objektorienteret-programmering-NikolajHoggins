using System;
namespace PersonRegister_Library
{
    public class Job
    {
        public string title;
        public Salary salary;
        public Company company;

        public Job(string title, Salary salary, Company company)
        {
            this.title = title;
            this.salary = salary;
            this.company = company;
        }
    }
}
