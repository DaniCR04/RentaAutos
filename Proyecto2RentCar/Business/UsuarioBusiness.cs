using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Domain;

namespace Business
{
    public class UsuarioBusiness
    {

        //ATRIBUTOS
        private string connectionString;
        private UsuarioData usuarioData;

        public UsuarioBusiness(string conn)
        {
            this.connectionString = conn;
            usuarioData = new UsuarioData(this.connectionString);
        }

        //LLAMADO A INSERTAR
        public void insertUsuario(Usuario usuario)
        {
            usuarioData.insertUsuarioData(usuario);
        }

        //LLAMADO A ELIMINAR
        public void deleteClient(string identificacion)
        {
            usuarioData.deleteUsuarioData(identificacion);
        }


    }
}
