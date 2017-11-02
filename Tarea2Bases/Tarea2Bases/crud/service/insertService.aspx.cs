using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.service
{
    public partial class InsertService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            ServiceBusiness serviceB = new ServiceBusiness(conn);

            serviceB.insertService(new Service(txtTypeService.Text, Int32.Parse(txtPrice.Text)));
        }
    }
}