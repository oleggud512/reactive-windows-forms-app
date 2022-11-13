using LiteDB;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.data
{
    public class ProductsRepository : IProductsRepository
    {
        LiteDatabase conn;
        readonly ILiteCollection<Product> productsCollection;

        public ProductsRepository(LiteDatabase conn)
        {
            this.conn = conn;
            productsCollection = conn.GetCollection<Product>();
        }

        public void AddProduct(Product product)
        {
            productsCollection.Insert(product);
        }

        public List<Product> GetProducts()
        {
            return productsCollection.Query().ToList();
        }

        public bool RemoveProduct(int id)
        {
            return productsCollection.Delete(id);
        }

        public void SaveProducts(List<Product> products)
        {
            productsCollection.DeleteAll();
            foreach (var product in products) productsCollection.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            productsCollection.Update(product);
        }

        public void Dispose()
        {

        }
    }
}
