using System;

namespace PayRoll
{
    class Program
    {
        public static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("Steve", "Smith", "947-463-8294", 900.00,06,12,1996);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Tony", "Stark","935-285-6645", 17.75, 40.0,07,13,1997);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Carol", "Danvers", "985-208-3483", 10000.00, .06,08,14,1998);
            BasePlusCommissionEmployee basePlusCommissionEmployee =new BasePlusCommissionEmployee("Natasha", "Romanoff","928-647-3264", 5000.00, .04, 300.00,09,15,1999);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\n{0} \nEarned: {1:C}",salariedEmployee.ToString(), salariedEmployee.Earnings());
            Console.WriteLine("\n{0} \nEarned: {1:C}", hourlyEmployee.ToString(), hourlyEmployee.Earnings());
            Console.WriteLine("\n{0} \nEarned: {1:C}", commissionEmployee.ToString(), commissionEmployee.Earnings());
            Console.WriteLine("\n{0} \nEarned: {1:C}", basePlusCommissionEmployee.ToString(), basePlusCommissionEmployee.Earnings());
            Console.WriteLine("-----------------------------------------------------------");

            Employee[] e = new Employee[4];
            e[0] = salariedEmployee;
            e[1] = hourlyEmployee;
            e[2] = commissionEmployee;
            e[3] = basePlusCommissionEmployee;

            Console.WriteLine("Employees processed polymorphically:\n");

            foreach (Employee emp in e)
            {
                 Console.WriteLine(emp);
                if (emp is BasePlusCommissionEmployee)
                {
                    BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)emp;
                    employee.BaseSalary *= 1.10;
                    Console.WriteLine("New base salary with 10% increase is: {0:C}",employee.BaseSalary);
                } // end if
                Console.WriteLine("Earned {0:C}\n", emp.Earnings());
            }
           

            }
        }
}
