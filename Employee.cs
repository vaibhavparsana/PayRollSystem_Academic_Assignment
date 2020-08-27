using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll
{
    public abstract class Employee
    {
        private DateTime _birthDate;
        public Employee(string first, string last, string ssn, int month, int day, int year)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
            BirthDate = new DateTime(year, month, day);
        }
        public DateTime BirthDate 
        {
            get
            {
                return _birthDate;
            } 
            set
            {
                _birthDate = value;
            } 
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public string SocialSecurityNumber
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nSocial Security Number: {2} \nBirthDay: {3}", FirstName, LastName, SocialSecurityNumber, BirthDate.ToString("d"));
        }
        public abstract double Earnings();
    }
}
