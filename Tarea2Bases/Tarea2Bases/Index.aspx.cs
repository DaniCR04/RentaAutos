using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            //string conn = "Data Source=163.178.107.130;Initial Catalog=db_if5100_dk;User ID=sqlserver;Password=saucr.12";

            UserLoginBusiness user = new UserLoginBusiness(conn);

            string result = "";

            result = user.validateLogin(new UserLogin(txtEmpl.Text , txtPass.Text));
            if (result == "A")
            {
                Response.Redirect("./IndexEmployee.aspx");
            }else
            {
                if (result == "U")
                {
                    Response.Redirect("./limitedUser.aspx.aspx");
                }else
                {
                    Response.Redirect("./error.aspx");
                }
            }
            
        }
    }
}