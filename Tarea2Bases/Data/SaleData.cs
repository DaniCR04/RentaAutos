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
    public class SaleData
    {
        //atributos
        private string connectionString;

        public SaleData(string conn)
        {
            this.connectionString = conn;
        }
    
        public string isertSale(Sale sale)
        {
            //Sale sale_number = this.getSaleInformation(sale);

            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_insert_sale";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@dni_employee", sale.dni_employee));
            cmdLog.Parameters.Add(new SqlParameter("@dni_client", sale.dni_client));

            //definir los parametros output
            SqlParameter idInvoice = new SqlParameter("@id_invoice", SqlDbType.Int);
            idInvoice.Direction = ParameterDirection.Output;

            //Se asignan los parametros ouput
            cmdLog.Parameters.Add(idInvoice);

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();

            string idInvoiceOut = cmdLog.Parameters["@id_invoice"].Value.ToString();

            return idInvoiceOut;
        }
    }
}
