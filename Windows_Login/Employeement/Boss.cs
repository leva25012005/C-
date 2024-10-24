using Checking_Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employeement
{
    public class Boss : Employee
    {
        public Boss(int id, string name, Salary salary, Date dob) : base(id, name, salary, dob) { }
        public override void SalaryCalculation(decimal rate = 1)
        {
            base.SalaryCalculation(rate);
        }

        public override string ToString()
        {
            return "Boss:\n" + base.ToString();
        }
    }
}