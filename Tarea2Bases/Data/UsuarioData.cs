using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class UsuarioData
    {

        //atributos
        private string connectionString;

        public UsuarioData(string conn)
        {
            this.connectionString = conn;
        }

        public void insertUsuarioData(Usuario usuario)
        {
            //establecemos la conexion
            SqlConnection connection = new SqlConnection(this.connectionString);

            //sql de insercion
            string sqlStoredProcedure = "sp_InsertarUsuario";
            SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

            //configurar el sql command
            cmdLog.CommandType = CommandType.StoredProcedure;

            cmdLog.Parameters.Add(new SqlParameter("@identificacion", usuario.identificacion));
            cmdLog.Parameters.Add(new SqlParameter("@tipoUsuario", usuario.tipoUsuario));
            cmdLog.Parameters.Add(new SqlParameter("@nombre", usuario.nombre));
            cmdLog.Parameters.Add(new SqlParameter("@apellidos", usuario.apellidos));
            cmdLog.Parameters.Add(new SqlParameter("@provincia", usuario.provincia));
            cmdLog.Parameters.Add(new SqlParameter("@canton", usuario.canton));
            cmdLog.Parameters.Add(new SqlParameter("@distrito", usuario.distrito));
            cmdLog.Parameters.Add(new SqlParameter("@correo", usuario.correo));
            cmdLog.Parameters.Add(new SqlParameter("@fechaRegistro", usuario.fechaRegistro));

            //ejecutamos el store procedure
            cmdLog.Connection.Open();
            cmdLog.ExecuteNonQuery();
        }




    }
}
