using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.data
{
    public interface IProductsRepository : IDisposable
    {
        public List<Product> GetProducts();
        public void AddProduct(Product product);
        public bool RemoveProduct(int id);
        public void UpdateProduct(Product product);
        public void SaveProducts(List<Product> products);
    }
}
