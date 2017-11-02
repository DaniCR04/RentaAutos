using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClientBusiness
    {
        //atributos
        private string connectionString;
        private ClientData clientData;

        public ClientBusiness(string conn)
        {
            this.connectionString = conn;
            clientData = new ClientData(this.connectionString);
        }

        public void insertClient(Client client)
        {
            clientData.insertClientData(client);
        }

        public void deleteClient(string dni)
        {
            clientData.deleteClientData(dni);
        }

        public void updateClient(Client client)
        {
            clientData.updateClientData(client);
        }

        public Client getClientInformation(string dni_client)
        {
            return clientData.getAllClientInformation(dni_client);
        }
        
    }
}
