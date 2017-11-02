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
    public partial class UpdateClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

           ClientBusiness clientB = new ClientBusiness(conn);

            clientB.updateClient(new Client(txtDni.Text, txtName.Text, txtLastName.Text,
            txtPhone_number.Text, txtPostal_code.Text, txtRuc.Text, txtCity.Text, txtDistrict.Text));
        }

        protected void txtLoadCli_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            ClientBusiness cliB = new ClientBusiness(conn);

            Client client = cliB.getClientInformation(txtLoadCli.Text);

            txtDni.Text = client.dni;
            txtName.Text = client.name;
            txtLastName.Text = client.last_name;
            txtPhone_number.Text = client.phone_number;
            txtPostal_code.Text = client.postal_code;
            txtRuc.Text = client.ruc;
            txtCity.Text = client.city;
            txtDistrict.Text = client.district;
        }
    }
}