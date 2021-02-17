using System;
namespace PersonRegister_Library
{
    public class Salary
    {
        private int monthlyPay;
        private string currencyCode;

        public Salary(int monthlyPay, string currencyCode)
        {
            this.monthlyPay = monthlyPay;
            this.currencyCode = currencyCode;
        }
    }
}
