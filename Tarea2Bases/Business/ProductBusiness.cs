using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        //atributos
        private string connectionString;
        private ProductData productData;

        public ProductBusiness(string conn)
        {
            this.connectionString = conn;
            productData = new ProductData(this.connectionString);
        }

        public void insertProduct(Product product)
        {
            productData.insertProductData(product);
        }

        public void deleteProduct(String product)
        {
            productData.deleteProduct(product);
        }

        public void updateProduct(Product product)
        {
            productData.updateProduct(product);
        }

        public Product getProductInformation(String product)
        {
            return productData.getAllProductInformation(product);
        }

        public void generateReportSells(String product)
        {
            productData.generateReportSellData(product);
        }
    }
}
