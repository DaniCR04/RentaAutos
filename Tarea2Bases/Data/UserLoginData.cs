using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserLoginData
    {
        //atributos
        private string connectionString;

        public UserLoginData(string conn) {
            this.connectionString = conn;
        }

        public string validateUserLogin(UserLogin user)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "spLoginUser";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni_employee", user.dni_employee));
            cmdLog.Parameters.Add(new SqlParameter("@pass", user.pass));

            //definir los parametros output
            SqlParameter isValidUser = new SqlParameter("@isValidUser", SqlDbType.Char);
            isValidUser.Direction = ParameterDirection.Output;
            isValidUser.Size = 1;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(isValidUser);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            //se obtiene los parametros output

            string temp = cmdLog.Parameters["@isValidUser"].Value.ToString();

            return temp;
        }
    }
}
