using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Checking_Date;

namespace Employeement
{
    public class Salary
    {
        public Date PayDate { get; set; }
        public decimal Rate { get; set; }
        const decimal StandardSalary = 200;

        public Salary() { }
        public Salary(Date payDate, decimal rate)
        {
            PayDate = payDate;
            Rate = rate;
            //StandardSalary = standardSalary;
        }

        public decimal CalculateTotalSalary()
        {
            return Rate * StandardSalary;
        }

        public string SalaryToString()
        {
            return $"Total Salary for {PayDate.ToDateString()}: {CalculateTotalSalary():C}";
        }
    }
}