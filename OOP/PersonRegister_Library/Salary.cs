using System;
namespace PersonRegister_Library
{
    public class Salary
    {
        public int monthlyPay;
        public string currencyCode;

        public Salary(int monthlyPay, string currencyCode)
        {
            this.monthlyPay = monthlyPay;
            this.currencyCode = currencyCode;
        }
    }
}
