using Checking_Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employeement
{
    public class HourlyWorker : Employee
    {
        public HourlyWorker(int id, string name, Salary salary, Date dob) : base(id, name, salary, dob) { }

        public override void SalaryCalculation(decimal rate = 0.8m)
        {
            base.SalaryCalculation(rate);
        }

        public override string ToString()
        {
            return "Hourly Worker:\n" + base.ToString();
        }
    }
}