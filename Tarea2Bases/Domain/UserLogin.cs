using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserLogin
    {
        public string dni_employee { get; set; }
        public string pass { get; set; }

        public UserLogin() { }

        public UserLogin(string dni_employee , string pass) {
            this.dni_employee = dni_employee;
            this.pass = pass;
        }
    }
}
