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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        static int n = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            //string conn = "Data Source=163.178.107.130;Initial Catalog=db_if5100_dk;User ID=sqlserver;Password=saucr.12";

            ProductBusiness productB = new ProductBusiness(conn);

            Product prodct = productB.getProductInformation(txtLoadProd.Text);

            txtProd.Text = prodct.name;

            string[] price = prodct.priceOut.Split('.');
            txtPrice.Text = price[0] + price[1];

            txtQuan.Text = prodct.quantityOut;
            txtMaker.Text = prodct.maker;

            string[] date = prodct.admission_date.ToString().Split(' ');
            txtAdmission_date.Text = date[0];
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            //string conn = "Data Source=163.178.107.130;Initial Catalog=db_if5100_dk;User ID=sqlserver;Password=saucr.12";
            ProductBusiness productB = new ProductBusiness(conn);

            productB.updateProduct(new Product(txtProd.Text, Int32.Parse(txtPrice.Text), Int32.Parse(txtQuan.Text),
            txtMaker.Text, txtAdmission_date.Text));
        }
    }
}