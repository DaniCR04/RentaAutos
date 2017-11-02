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
    public class ProductData
    {
        //atributos
        private string connectionString;

        public ProductData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertProductData(Product product)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_insert_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@name", product.name));
            cmdLog.Parameters.Add(new SqlParameter("@price", product.price));
            cmdLog.Parameters.Add(new SqlParameter("@quantity", product.quantity));
            cmdLog.Parameters.Add(new SqlParameter("@maker", product.maker));
            cmdLog.Parameters.Add(new SqlParameter("@admission_date", product.admission_date));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public int getIdProduct(string product) {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "getIdProduct";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            //definir los parametros output
            SqlParameter idProduct = new SqlParameter("@id_Product", SqlDbType.Int);
            idProduct.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(idProduct);

            cmdLog.Parameters.Add(new SqlParameter("@product", product));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            int id = Int32.Parse(cmdLog.Parameters["@id_Product"].Value.ToString());

            return id;
        }

        public void deleteProduct(string product)
        {
            //Se obtiene el id del producto
            int id = getIdProduct(product);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_delete_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id", id));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void updateProduct(Product product)
        {

            //Se obtiene el id del producto
            int id = getIdProduct(product.name);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_update_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@id", id));
            cmdLog.Parameters.Add(new SqlParameter("@name", product.name));
            cmdLog.Parameters.Add(new SqlParameter("@price", product.price));
            cmdLog.Parameters.Add(new SqlParameter("@quantity", product.quantity));
            cmdLog.Parameters.Add(new SqlParameter("@maker", product.maker));
            cmdLog.Parameters.Add(new SqlParameter("@admission_date", DateTime.Parse(product.admission_date)));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public Product getAllProductInformation(string product)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_get_all_product_information";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@name", product));

            //definir los parametros output
            SqlParameter price = new SqlParameter("@price", SqlDbType.Money);
            price.Direction = ParameterDirection.Output;

            SqlParameter quantity = new SqlParameter("@quantity", SqlDbType.Int);
            quantity.Direction = ParameterDirection.Output;

            SqlParameter maker = new SqlParameter("@maker", SqlDbType.NVarChar);
            maker.Size = 20;
            maker.Direction = ParameterDirection.Output;

            SqlParameter admission_date = new SqlParameter("@admission_date", SqlDbType.Date);
            admission_date.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(price);
            cmdLog.Parameters.Add(quantity);
            cmdLog.Parameters.Add(maker);
            cmdLog.Parameters.Add(admission_date);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            string priceOut = "", quantityOut = "", makerOut = "",admDateOut = "";

            priceOut = cmdLog.Parameters["@price"].Value.ToString();
            quantityOut = cmdLog.Parameters["@quantity"].Value.ToString();
            makerOut = cmdLog.Parameters["@maker"].Value.ToString();
            admDateOut = cmdLog.Parameters["@admission_date"].Value.ToString();

            Product returnProduct = new Product(product, priceOut, quantityOut, makerOut, admDateOut , 0);

            return returnProduct;
        }

        public void actionProduct(Product product) {

            //int id = getInformationProduct(product.name);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_general_content_product";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            //cmdLog.Parameters.Add(new SqlParameter("@id_product", id));
            cmdLog.Parameters.Add(new SqlParameter("@quantity", product.quantity));
            //cmdLog.Parameters.Add(new SqlParameter("@action", product.action));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }

        public void generateReportSellData(String product)
        {

            //Se obtiene el id del producto
            int id = getIdProduct(product);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "consultarVentas_sp";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@idProduct ", id));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }
    }
}
