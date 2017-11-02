using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.product
{
    public partial class IndexInsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            ProductBusiness productB = new ProductBusiness(conn);

            productB.insertProduct(new Product(txtProd.Text, Int32.Parse(txtPrice.Text), Int32.Parse(txtQuan.Text), 
            txtMaker.Text , txtAdmission_date.Text));
        }
    }
}