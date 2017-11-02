using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.client
{
    public partial class insertClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            ClientBusiness clientB = new ClientBusiness(conn);

            clientB.insertClient(new Client(txtDni.Text, txtName.Text, txtLastName.Text, 
            txtPhone_number.Text, txtPostal_code.Text, txtRuc.Text, txtCity.Text, txtDistrict.Text));
        }
    }
}