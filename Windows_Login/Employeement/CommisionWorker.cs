using Checking_Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Employeement
{
    public class CommisionWorker : Employee
    {
        public CommisionWorker(int id, string name, Salary salary, Date dob) : base(id, name, salary, dob) { }

        public override void SalaryCalculation(decimal rate = 0.5m)
        {
            base.SalaryCalculation(rate);
        }

        public override string ToString()
        {
            return "Commission Worker:\n" + base.ToString();
        }
    }
}