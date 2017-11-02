using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UsuarioBusiness
    {

        //atributos
        private string connectionString;
        private UsuarioData usuarioData;

         public UsuarioBusiness(string conn)
        {
            this.connectionString = conn;
            usuarioData = new UsuarioData(this.connectionString);
        }

        public void insertUsuario(Usuario usuario)
        {
            usuarioData.insertUsuarioData(usuario);
        }


    }
}
