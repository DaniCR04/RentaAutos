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
    public class ContentData
    {
        //atributos
        private string connectionString;

        public ContentData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertContentProduct(Content content)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_general_content_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id_product", content.id_product));
            cmdLog.Parameters.Add(new SqlParameter("@id_invoice", content.id_invoice));
            cmdLog.Parameters.Add(new SqlParameter("@quantity", content.quantity));
            cmdLog.Parameters.Add(new SqlParameter("@action", content.action));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void insertContentService(Content content)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_general_content_service";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id_service", content.id_product));
            cmdLog.Parameters.Add(new SqlParameter("@id_invoice", content.id_invoice));
            cmdLog.Parameters.Add(new SqlParameter("@action", content.action));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void deleteContentProduct(Content content)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_general_content_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id_product", content.id_product));
            cmdLog.Parameters.Add(new SqlParameter("@id_invoice", content.id_invoice));
            cmdLog.Parameters.Add(new SqlParameter("@quantity", content.quantity));
            cmdLog.Parameters.Add(new SqlParameter("@action", content.action));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void deleteContentService(Content content)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_general_content_service";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id_service", content.id_product));
            cmdLog.Parameters.Add(new SqlParameter("@id_invoice", content.id_invoice));
            cmdLog.Parameters.Add(new SqlParameter("@action", content.action));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public int getIdProductData(string product)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "getIdProduct";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@product", product));

            //definir los parametros output
            SqlParameter idProduct = new SqlParameter("@id_product", SqlDbType.Int);
            idProduct.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(idProduct);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            int idProductOut = 0;

            idProductOut = Int32.Parse(cmdLog.Parameters["@id_product"].Value.ToString());

            return idProductOut;
        }

        public int getIdServiceData(string service)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "getIdService";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@type_service", service));

            //definir los parametros output
            SqlParameter idService = new SqlParameter("@id_service", SqlDbType.Int);
            idService.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(idService);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            int idServiceOut = 0;

            string m = cmdLog.Parameters["@id_service"].Value.ToString();

            idServiceOut = Convert.ToInt32(cmdLog.Parameters["@id_service"].Value.ToString());
            idServiceOut = Int32.Parse(cmdLog.Parameters["@id_service"].Value.ToString());

            return idServiceOut;
        }
    }
}
