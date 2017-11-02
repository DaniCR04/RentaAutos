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
    public class PaysheetData
    {
        //atributos
        private string connectionString;

        public PaysheetData(string conn)
        {
            this.connectionString = conn;
        }

        public void generatePaysheet(Paysheet paysheet)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_generate_paysheet";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@date", DateTime.Parse(paysheet.date)));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }
    }
}
