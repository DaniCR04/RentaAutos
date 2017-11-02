using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service
    {
        public string old_type_service { get; set; }

        public string new_type_service { get; set; }

        public int price { get; set; }

        public Service(string new_type_service, int price)
        {
            this.old_type_service = old_type_service;
            this.new_type_service = new_type_service;
            this.price = price;
        }

        public Service(string old_type_service, string new_type_service, int price)
        {
            this.old_type_service = old_type_service;
            this.new_type_service = new_type_service;
            this.price = price;
        }
    }
}
