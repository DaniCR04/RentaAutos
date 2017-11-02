using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PaysheetBusiness
    {
        //atributos
        private string connectionString;
        private PaysheetData paysheetData;

        public PaysheetBusiness(string conn)
        {
            this.connectionString = conn;
            paysheetData = new PaysheetData(this.connectionString);
        }

        public void generatePaysheet(Paysheet paysheet)
        {
            paysheetData.generatePaysheet(paysheet);
        }
    }
}
