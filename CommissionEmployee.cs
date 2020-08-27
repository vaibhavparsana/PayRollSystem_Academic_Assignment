using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll
{
    public class CommissionEmployee : Employee
    {
        private double grossSales; 
        private double commissionRate;

        public CommissionEmployee(string first, string last, string ssn, double sales, double rate, int month, int day, int year) : base(first, last, ssn, month, day, year)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }

        public double GrossSales
        {
             get
             {
             return grossSales;
             } 
             set
             {
                if (value >= 0)
                {
                    grossSales = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(
                                 "GrossSales", value, "GrossSales must be >= 0");

                }
            } 
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if(value>0 && value <1)
                {
                    commissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("CommissionRate",
                          value, "CommissionRate must be > 0 and < 1");
                }
            }
        }

        public override double Earnings()
        {
            if (DateTime.UtcNow.Month == base.BirthDate.Month)
            {

                return CommissionRate * GrossSales + 100;
            }
            else
            {
                return CommissionRate * GrossSales;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}","Commission Employee", base.ToString(),"Gross sales", GrossSales, "Commission rate", CommissionRate);
        }
    }
}
