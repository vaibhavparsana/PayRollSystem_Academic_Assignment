using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;
 

        public SalariedEmployee(string first, string last, string ssn, double salary, int month, int day, int year) : base(first, last, ssn, month, day, year)
        {
            WeeklySalary = salary;
            
        }

        public double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
               
                if(value >=0)
                {
        
                    if (DateTime.UtcNow.Month == base.BirthDate.Month)
                    {
                        weeklySalary = value + 100;
                    }else
                    {
                        weeklySalary = value;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("weeklySalary", value, "weeklySalary must be >= 0;");
                }
            }
        }

        public override double Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return string.Format("Salaried Employee: {0}\n{1}: {2:C}",base.ToString(), "Weekly Salary", WeeklySalary);
        }
    }
}
