using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, double sales, double rate, double salary, int month, int day, int year) : base(first, last, ssn, sales, rate, month, day, year)
        {
            BaseSalary = salary;
        }

        public double BaseSalary 
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if(value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("BaseSalary",
                         value, "BaseSalary must be >= 0");
                }
            }
        }

        public override double Earnings()
        {
              
            return BaseSalary + base.Earnings();
            
        }

        public override string ToString()
        {
            return string.Format("Base Plus {0} \nBase Salary: {1:C}",base.ToString(), BaseSalary);
        }
    }
}
