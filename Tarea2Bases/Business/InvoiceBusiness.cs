using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class InvoiceBusiness
    {
        //atributos
        private string connectionString;
        private InvoiceData invoiceData;

        public InvoiceBusiness(string conn)
        {
            this.connectionString = conn;
            invoiceData = new InvoiceData(this.connectionString);
        }

        public void updateInvoice(Invoice invoice)
        {
            invoiceData.updateInvoice(invoice);
        }
    }
}
