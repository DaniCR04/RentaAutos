using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SaleBusiness
    {
        //atributos
        private string connectionString;
        private SaleData saleData;

        public SaleBusiness(string conn)
        {
            this.connectionString = conn;
            saleData = new SaleData(this.connectionString);
        }

        public string insertSale(Sale sale)
        {
            return saleData.isertSale(sale);
        }
    }
}
