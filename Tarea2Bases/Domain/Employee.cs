using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        public string dni { get; set; }

        public string name { get; set; }

        public string last_name { get; set; }

        public string phone_number { get; set; }

        public string account_number { get; set; }

        public string social_security { get; set; }

        public string city { get; set; }

        public string district { get; set; }

        public string salary { get; set; }

        public Employee(string dni, string salary , string name , string last_name , string phone_number , string account_number , 
            string social_security , string city , string district)
        {
            this.dni = dni;
            this.name = name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.account_number = account_number;
            this.social_security = social_security;
            this.city = city;
            this.district = district;
            this.salary = salary;
        }

    }
}
