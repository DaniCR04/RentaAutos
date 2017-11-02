using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sale
    {
        public string dni_employee { get; set; }
        public string dni_client { get; set; }

        public Sale(string dni_employee, string dni_client)
        {
            this.dni_employee = dni_employee;
            this.dni_client = dni_client;
        }
    }
}
