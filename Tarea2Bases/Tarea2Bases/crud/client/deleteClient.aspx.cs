using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.client
{
    public partial class deleteClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            ClientBusiness clientB = new ClientBusiness(conn);

            clientB.deleteClient(txtDni.Text);
        }
    }
}