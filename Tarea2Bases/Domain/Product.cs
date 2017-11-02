using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        //public int quantity { get; set; }
       // public string action { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string priceOut { get; set; }
        public int quantity { get; set; }
        public string quantityOut { get; set; }
        public string maker { get; set; }
        public string admission_date { get; set; }

        public Product() { }

        public Product(string name , int price , int quantity , string maker , string admission_date)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.maker = maker;
            this.admission_date = admission_date;
        }

        public Product(string name, string priceOut, string quantityOut, string maker, string admission_date , int t)
        {
            this.name = name;
            this.priceOut = priceOut;
            this.quantityOut = quantityOut;
            this.maker = maker;
            this.admission_date = admission_date;
        }
    }
}
