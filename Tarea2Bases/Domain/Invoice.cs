using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Invoice
    {
        public int id;
        
        public Invoice() { }
        
        public Invoice (int id)
        {
            this.id = id;
        } 
    }
}
