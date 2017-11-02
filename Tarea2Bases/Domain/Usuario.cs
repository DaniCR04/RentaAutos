using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Usuario
    {

        public string identificacion { get; set; }

        public string tipoUsuario { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public string provincia { get; set; }

        public string canton { get; set; }

        public string distrito { get; set; }

        public string correo { get; set; }

        public string fechaRegistro { get; set; }

        public Usuario(string identificacion, string tipoUsuario, string nombre, string apellidos, string provincia,
            string canton, string distrito, string correo, string fechaRegistro)
        {
            this.identificacion = identificacion;
            this.tipoUsuario = tipoUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.correo = correo;
            this.fechaRegistro = fechaRegistro;
        }



    }
}
