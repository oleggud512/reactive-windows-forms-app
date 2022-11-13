using PrOOPz3.src.features.products.data;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.application
{
    public class ProductsToAddService
    {
        IProductsRepository productsRepository;

        public ProductsToAddService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public List<Product> GetProducts(string query = "")
        {
            return productsRepository.GetProducts()
                .Where((product) => product.Name.Contains(query)) // could be complex. 
                .ToList();
        }
    }
}
