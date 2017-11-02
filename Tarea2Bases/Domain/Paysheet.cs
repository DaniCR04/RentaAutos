using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Paysheet
    {
        public string date;

        public Paysheet () { }

        public Paysheet (string date)
        {
            this.date = date;
        }
    }
}
