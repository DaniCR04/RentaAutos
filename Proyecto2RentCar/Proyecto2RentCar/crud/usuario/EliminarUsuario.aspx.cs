using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

using Business;

namespace Proyecto2RentCar.crud.usuario
{
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            UsuarioBusiness usuarioB = new UsuarioBusiness(conn);

            usuarioB.deleteClient(txtidentificacion.Text);

            MessageBox.Show("Mensaje informativo", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Limpio los campos cada vez que inserta
            txtidentificacion.Text = "";

        }

    }
}