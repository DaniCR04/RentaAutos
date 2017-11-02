using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ContentBusiness
    {
        //atributos
        private string connectionString;
        private ContentData clientData;

        public ContentBusiness(string conn)
        {
            this.connectionString = conn;
            clientData = new ContentData(this.connectionString);
        }

        public void insertContentProduct(Content content)
        {
            clientData.insertContentProduct(content);
        }

        public void insertContentService(Content content)
        {
            clientData.insertContentService(content);
        }

        public void deleteContentProduct(Content content)
        {
            clientData.deleteContentProduct(content);
        }

        public void deleteContentService(Content content)
        {
            clientData.deleteContentService(content);
        }

        public int getIdProduct(string product)
        {
            return clientData.getIdProductData(product);
        }

        public int getIdServiceData(string service)
        {
            return clientData.getIdServiceData(service);
        }
    }
}
