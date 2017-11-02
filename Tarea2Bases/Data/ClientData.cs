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
    public class ClientData
    {
        //atributos
        private string connectionString;
    
        public ClientData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertClientData(Client client)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_insert_client";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", client.dni));
            cmdLog.Parameters.Add(new SqlParameter("@name", client.name));
            cmdLog.Parameters.Add(new SqlParameter("@last_name", client.last_name));
            cmdLog.Parameters.Add(new SqlParameter("@phone_number", client.phone_number));
            cmdLog.Parameters.Add(new SqlParameter("@postal_code", client.postal_code));
            cmdLog.Parameters.Add(new SqlParameter("@ruc", client.ruc));
            cmdLog.Parameters.Add(new SqlParameter("@city", client.city));
            cmdLog.Parameters.Add(new SqlParameter("@district", client.district));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void deleteClientData(string dni)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_delete_client";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", dni));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void updateClientData(Client client)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_update_client";
             SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni", client.dni));
            cmdLog.Parameters.Add(new SqlParameter("@name", client.name));
            cmdLog.Parameters.Add(new SqlParameter("@last_name", client.last_name));
            cmdLog.Parameters.Add(new SqlParameter("@phone_number", client.phone_number));
            cmdLog.Parameters.Add(new SqlParameter("@postal_code", client.postal_code));
            cmdLog.Parameters.Add(new SqlParameter("@ruc", client.ruc));
            cmdLog.Parameters.Add(new SqlParameter("@city", client.city));
            cmdLog.Parameters.Add(new SqlParameter("@district", client.district));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public Client getAllClientInformation(string dni)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_get_all_client_information";
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

            SqlParameter phoneNumber = new SqlParameter("@phone_number", SqlDbType.Char);
            phoneNumber.Size = 8;
            phoneNumber.Direction = ParameterDirection.Output;

            SqlParameter postalCode = new SqlParameter("@postal_code", SqlDbType.Char);
            postalCode.Size = 5;
            postalCode.Direction = ParameterDirection.Output;

            SqlParameter ruc = new SqlParameter("@ruc", SqlDbType.Char);
            ruc.Size = 11;
            ruc.Direction = ParameterDirection.Output;

            SqlParameter city = new SqlParameter("@city", SqlDbType.NVarChar);
            city.Size = 20;
            city.Direction = ParameterDirection.Output;

            SqlParameter district = new SqlParameter("@district", SqlDbType.NVarChar);
            district.Size = 20;
            district.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(name);
            cmdLog.Parameters.Add(lastName);
            cmdLog.Parameters.Add(phoneNumber);
            cmdLog.Parameters.Add(postalCode); 
            cmdLog.Parameters.Add(ruc);
            cmdLog.Parameters.Add(city);
            cmdLog.Parameters.Add(district);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            string nameOut = "", lastNameOut = "", phoneNumberOut = "", postalCodeOut = "", 
                rucOut = "" , cityOut = "" , districtOut = "";

            nameOut = cmdLog.Parameters["@name"].Value.ToString();
            lastNameOut = cmdLog.Parameters["@last_name"].Value.ToString();
            phoneNumberOut = cmdLog.Parameters["@phone_number"].Value.ToString();
            postalCodeOut = cmdLog.Parameters["@postal_code"].Value.ToString();
            rucOut = cmdLog.Parameters["@ruc"].Value.ToString();
            cityOut = cmdLog.Parameters["@city"].Value.ToString();
            districtOut = cmdLog.Parameters["@district"].Value.ToString();

            Client returnClient = new Client(dni, nameOut, lastNameOut, phoneNumberOut, postalCodeOut,
            rucOut, cityOut, districtOut);

            return returnClient;
        }
    }
}
