using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserLoginBusiness
    {
        //atributos
        private string connectionString;
        private UserLoginData userData;

        public UserLoginBusiness(string conn)
        {
            this.connectionString = conn;
            userData = new UserLoginData(this.connectionString);
        }

        public string validateLogin(UserLogin user)
        {
            return userData.validateUserLogin(user);
        }
    }
}
