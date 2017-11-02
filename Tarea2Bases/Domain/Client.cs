using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client
    {
        public string dni { get; set; }
  
        public string name { get; set; }

        public string last_name { get; set; }

        public string phone_number { get; set; }

        public string postal_code { get; set; }

        public string ruc { get; set; }

        public string city { get; set; }

        public string district { get; set; }

        public Client(string dni, string name, string last_name, string phone_number, string postal_code,
            string ruc, string city, string district)
        {
            this.dni = dni;
            this.name = name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.postal_code = postal_code;
            this.ruc = ruc;
            this.city = city;
            this.district = district;
        }
    }
}
