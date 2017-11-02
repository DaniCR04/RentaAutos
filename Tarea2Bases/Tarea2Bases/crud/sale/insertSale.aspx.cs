using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.sale
{
    public partial class InsertSale : System.Web.UI.Page
    {
        private static string idInvoice;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnInsertCS_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            ContentBusiness contB = new ContentBusiness(conn);

            int idService = contB.getIdServiceData(txtService.Text);

            /*contB.insertContentService(new Domain.Content(idService , Int32.Parse(idInvoice), "insert"));*/

            contB.insertContentService(new Domain.Content(idService, 4, "insert"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            ContentBusiness contB = new ContentBusiness(conn);

            int idProduct = contB.getIdProduct(txtIdPro.Text);

            /*contB.insertContentProduct(new Domain.Content(idProduct, Int32.Parse(idInvoice), 
            Int32.Parse(txtQuant.Text), "insert"));*/

            contB.insertContentProduct(new Domain.Content(idProduct, 3,
            Int32.Parse(txtQuant.Text), "insert"));
        }

        protected void btnInertSale_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            SaleBusiness saleB = new SaleBusiness(conn);

            idInvoice = saleB.insertSale(new Sale(txtCedEmp.Text, txtCedCli.Text));
        }

        protected void btnDeleteContent_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            ContentBusiness contB = new ContentBusiness(conn);

            int idProduct = contB.getIdServiceData(txtService.Text);

            //contB.deleteContentService(new Domain.Content(idProduct, Int32.Parse(idInvoice), "deleting"));

            contB.deleteContentService(new Domain.Content(idProduct, 4, "deleting"));
        }

        protected void btnDelPro_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            ContentBusiness contB = new ContentBusiness(conn);

            int idProduct = contB.getIdProduct(txtIdPro.Text);

            /*contB.deleteContentProduct(new Domain.Content(idProduct, Int32.Parse(idInvoice),
            Int32.Parse(txtQuant.Text), "deleting"));*/

            contB.deleteContentProduct(new Domain.Content(idProduct, 1,
            Int32.Parse(txtQuant.Text), "deleting"));
        }
    }
}