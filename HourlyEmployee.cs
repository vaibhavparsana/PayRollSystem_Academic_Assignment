using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll
{
    class HourlyEmployee : Employee
    {
         private double wage;
         private double hours;

        public HourlyEmployee(string first, string last, string ssn, double hourlyWage, double HoursWorked, int month, int day, int year) : base(first, last, ssn, month, day, year)
        {
            Wage = hourlyWage;
            Hours = HoursWorked;
        }


        public double Wage 
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0)
                {
                    if (DateTime.UtcNow.Month == base.BirthDate.Month)
                    {
                        wage = value + 100;
                    }
                    else
                    {
                        wage = value;
                    }
                }
                else 
                { 
                    throw new ArgumentOutOfRangeException("Wage",
                    value, "Wage must be >= 0");
                }
            }

        }
        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168)
                {
                    hours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours",
                    value, "Hours must be >= 0");
                }
            }

        }

        public override double Earnings()
        {
            if (Hours <= 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5);
            }
        }

        public override string ToString()
        {
            return string.Format("Hourly Employee: {0}\n{1}: {2:C} \n{3}: {4:F2}",base.ToString(), "Hourly Wage", Wage, "Hours Worked", Hours);
        }
    }

}
