using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.paysheet
{
    public partial class GeneratePaysheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            PaysheetBusiness paysheetBussiness = new PaysheetBusiness(conn);

            string month = Calendar1.SelectedDate.Month.ToString();

            paysheetBussiness.generatePaysheet(new Domain.Paysheet(Calendar1.SelectedDate.ToShortDateString()));
        }
    }
}