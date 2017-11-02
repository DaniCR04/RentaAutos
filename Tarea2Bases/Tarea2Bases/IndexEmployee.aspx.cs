using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases
{
    public partial class IndexEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogOut_Click1(object sender, EventArgs e)
        {
            Session.Abandon();

            Response.Redirect("./Index.aspx");
        }

    }
}