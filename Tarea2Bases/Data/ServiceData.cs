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
    public class ServiceData
    {
        //atributos
        private string connectionString;

        public ServiceData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertServiceData(Service service)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_insert_service";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@type_service", service.new_type_service));
            cmdLog.Parameters.Add(new SqlParameter("@price", service.price));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public int getIdService(string service)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "getIdService";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            //definir los parametros output
            SqlParameter idProduct = new SqlParameter("@id_service", SqlDbType.Int);
            idProduct.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(idProduct);

            cmdLog.Parameters.Add(new SqlParameter("@type_service", service));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            int id = Int32.Parse(cmdLog.Parameters["@id_service"].Value.ToString());

            return id;
        }

        public void deleteService(string service)
        {
            //Se obtiene el id del producto
            int id = getIdService(service);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_delete_service";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id", id));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void updateService(Service service)
        {
            //Se obtiene el id del producto
            int id = getIdService(service.old_type_service);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_update_service";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id", id));
            cmdLog.Parameters.Add(new SqlParameter("@type_service", service.new_type_service));
            cmdLog.Parameters.Add(new SqlParameter("@price", service.price));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public string getAllServiceInformation(string typeService)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_get_all_service_information";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@type_service", typeService));

            //definir los parametros output
            SqlParameter price = new SqlParameter("@price", SqlDbType.Int);
            price.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(price);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            string priceOut = "";

            priceOut = cmdLog.Parameters["@price"].Value.ToString();

            return priceOut;
        }
    }
}
