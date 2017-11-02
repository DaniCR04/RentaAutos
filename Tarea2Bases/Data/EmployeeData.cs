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
    public class EmployeeData
    {
        //atributos
        private string connectionString;

        public EmployeeData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertEmployeeData(Employee employee)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_insert_employee";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", employee.dni));
            cmdLog.Parameters.Add(new SqlParameter("@salary", employee.salary));
            cmdLog.Parameters.Add(new SqlParameter("@name", employee.name));
            cmdLog.Parameters.Add(new SqlParameter("@last_name", employee.last_name));
            cmdLog.Parameters.Add(new SqlParameter("@phone_number", employee.phone_number));
            cmdLog.Parameters.Add(new SqlParameter("@account_number", employee.account_number));
            cmdLog.Parameters.Add(new SqlParameter("@social_security", employee.social_security));
            cmdLog.Parameters.Add(new SqlParameter("@city", employee.city));
            cmdLog.Parameters.Add(new SqlParameter("@district", employee.district));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void deleteEmployeeData(string dni)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_delete_employee";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", dni));
            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void updateEmployeeData(Employee employee)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_update_employee";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", employee.dni));
            cmdLog.Parameters.Add(new SqlParameter("@name", employee.name));
            cmdLog.Parameters.Add(new SqlParameter("@last_name", employee.last_name));
            cmdLog.Parameters.Add(new SqlParameter("@phone_number", employee.phone_number));
            cmdLog.Parameters.Add(new SqlParameter("@account_number", employee.account_number));
            cmdLog.Parameters.Add(new SqlParameter("@social_security", employee.social_security));
            cmdLog.Parameters.Add(new SqlParameter("@city", employee.city));
            cmdLog.Parameters.Add(new SqlParameter("@district", employee.district));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public Employee getEmployeeInformation(string dni)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_get_all_employee_information";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", dni));

            //definir los parametros output
            SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
            name.Size = 20;
            name.Direction = ParameterDirection.Output;

            SqlParameter lastName = new SqlParameter("@last_name", SqlDbType.NVarChar);
            lastName.Size = 30;
            lastName.Direction = ParameterDirection.Output;

            SqlParameter salary = new SqlParameter("@salary", SqlDbType.Money);
            salary.Direction = ParameterDirection.Output;

            SqlParameter phoneNumber = new SqlParameter("@phone_number", SqlDbType.Char);
            phoneNumber.Size = 8;
            phoneNumber.Direction = ParameterDirection.Output;

            SqlParameter accountNumber = new SqlParameter("@account_number", SqlDbType.Char);
            accountNumber.Size = 17;
            accountNumber.Direction = ParameterDirection.Output;

            SqlParameter socialSecurity = new SqlParameter("@social_security", SqlDbType.Char);
            socialSecurity.Size = 9;
            socialSecurity.Direction = ParameterDirection.Output;

            SqlParameter city = new SqlParameter("@city", SqlDbType.Char);
            city.Size = 9;
            city.Direction = ParameterDirection.Output;

            SqlParameter district = new SqlParameter("@district", SqlDbType.NVarChar);
            district.Size = 20;
            district.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(name);
            cmdLog.Parameters.Add(lastName);
            cmdLog.Parameters.Add(salary);
            cmdLog.Parameters.Add(phoneNumber);
            cmdLog.Parameters.Add(accountNumber);
            cmdLog.Parameters.Add(socialSecurity);
            cmdLog.Parameters.Add(city);
            cmdLog.Parameters.Add(district);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            string nameOut = "", lastNameOut = "", salaryOut = "", phoneNumberOut = "",
                accountNumberOut = "", socialSecurityOut = "", cityOut = "", districtOut="";

            nameOut = cmdLog.Parameters["@name"].Value.ToString();
            lastNameOut = cmdLog.Parameters["@last_name"].Value.ToString();
            salaryOut = cmdLog.Parameters["@salary"].Value.ToString();
            phoneNumberOut = cmdLog.Parameters["@phone_number"].Value.ToString();
            accountNumberOut = cmdLog.Parameters["@account_number"].Value.ToString();
            socialSecurityOut = cmdLog.Parameters["@social_security"].Value.ToString();
            cityOut = cmdLog.Parameters["@city"].Value.ToString();
            districtOut = cmdLog.Parameters["@district"].Value.ToString();

            Employee returnEmployee = new Employee(
            dni, salaryOut, nameOut, lastNameOut, phoneNumberOut, accountNumberOut, 
            socialSecurityOut, cityOut, districtOut);

            return returnEmployee;
        }


    }
}
