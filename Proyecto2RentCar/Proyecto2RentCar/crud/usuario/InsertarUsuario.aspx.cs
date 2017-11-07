using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

using Business;
using Domain;

namespace Proyecto2RentCar.crud.usuario
{
    public partial class InsertarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            UsuarioBusiness usuarioB = new UsuarioBusiness(conn);

            usuarioB.insertUsuario(new Usuario(txtidentificacion.Text, txttipoUsuario.Text, txtnombre.Text,
            txtapellidos.Text, txtprovincia.Text, txtcanton.Text, txtdistrito.Text, txtcorreo.Text, txtfechaRegistro.Text));

            //Limpio los campos cada vez que inserta
            txtidentificacion.Text = "";
            txttipoUsuario.Text = "";
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtprovincia.Text = "";
            txtcanton.Text = "";
            txtdistrito.Text = "";
            txtcorreo.Text = "";
            txtfechaRegistro.Text = "";

        }

    }
}