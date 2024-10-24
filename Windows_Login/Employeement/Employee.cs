using Checking_Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeement
{
    public abstract class Employee
    {
        int id;
        string name;
        Salary salary;
        Date dob;
        public Employee() { }
        public Employee(int id, string name, Salary salary, Date dob)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Dob = dob;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Salary Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Date Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public virtual void SalaryCalculation(decimal rate)
        {
            Salary = new Salary { Rate = rate };
            Salary.CalculateTotalSalary();
        }

        //public abstract decimal Earnings();

        public override string ToString()
        {
            return $"- ID: {Id}\n" +
                   $"- Name: {Name}\n" +
                   $"- Date of Birth: {Dob.ToDateString()}" +
                   $"\n- Salary: {Salary.SalaryToString()}";
        }
    }
}
