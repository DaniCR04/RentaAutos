using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Content
    {
        public int id_product { get; set; }

        public int id_invoice { get; set; }

        public int quantity { get; set; }

        public string action { get; set; }

        //Producto
        public Content(int id_product , int id_invoice , int quantity , string action)
        {
            this.id_product = id_product;
            this.id_invoice = id_invoice;
            this.quantity = quantity;
            this.action = action;
        }

        //Servicio
        public Content(int id_product, int id_invoice, string action)
        {
            this.id_product = id_product;
            this.id_invoice = id_invoice;
            this.quantity = quantity;
            this.action = action;
        }
    }
}
