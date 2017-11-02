using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ServiceBusiness
    {
        //atributos
        private string connectionString;
        private ServiceData serviceData;

        public ServiceBusiness(string conn)
        {
            this.connectionString = conn;
            serviceData = new ServiceData(this.connectionString);
        }

        public void insertService(Service service)
        {
            serviceData.insertServiceData(service);
        }

        public void deleteService(string service)
        {
            serviceData.deleteService(service);
        }

        public void updateService(Service service)
        {
            serviceData.updateService(service);
        }

        public string getAllServiceInformation(String service)
        {
            return serviceData.getAllServiceInformation(service);
        }
    }
}
