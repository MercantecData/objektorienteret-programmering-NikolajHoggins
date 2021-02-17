using System;

namespace School_Library
{
    public class Salary
    {
        private bool isPaid;
        private decimal monthlyPay;
        private DateTime paidDate;

        public Salary(decimal monthlyPay)
        {
            this.monthlyPay = monthlyPay;
        }

        
        /// <summary>
        /// Get if the salary has been paid this month
        /// </summary>
        public bool GetPaidStatus()
        {
            //If we were paid this month, return true, if not, we set ispaid to false, so we can pay the teacher.
            if (this.paidDate.Month == DateTime.Now.Month)
            {
                return this.isPaid;    
            }
            else
            {
                this.isPaid = false;
                return this.isPaid;
            }
        }

        public decimal GetMonthlyPay()
        {
            return this.monthlyPay;
        }
        
        public void PaySalary()
        {
            if (!this.isPaid)
            {
                this.paidDate = DateTime.Now;
                this.isPaid = true;    
            }
            else
            {
                //Here I would throw an custom error, and do a try catch to catch if the teacher has already been paid. This is out of scope and timefram though, so it will not be implemented.
            }
        } 
    }
}