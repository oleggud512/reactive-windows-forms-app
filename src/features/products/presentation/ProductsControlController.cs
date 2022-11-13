using PrOOPz3.src.features.customers.presentation.customers;
using PrOOPz3.src.features.products.data;
using PrOOPz3.src.features.products.domain;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.presentation
{
    public class ProductsControlController : StateObservable<ProductsControlState>
    {
        IProductsRepository productsRepository;
        public ProductsControlController(IProductsRepository productsRepository) 
            : base(new ProductsControlState())
        {
            this.productsRepository = productsRepository;
            RefreshProducts();
        }

        public int CurrentIndex
        {
            set
            {
                State = new ProductsControlState() { Products = State.Products, CurrentIndex = value };
            }
        }

        public void RemoveProduct(int id)
        {
            productsRepository.RemoveProduct(id);
            RefreshProducts();
        }

        public void AddProduct(string name, double price, double weight)
        {
            productsRepository.AddProduct(new Product() { Name = name, Price = price, Weight = weight });
            RefreshProducts();
        }

        public void UpdateProduct(int id, string? name = null, double? price = null, double? weight = null)
        {
            productsRepository.UpdateProduct(
                State.Products.First(p => p.Id == id).CopyWith(
                    name: name, 
                    price: price, 
                    weight: weight
                    )
            );
            RefreshProducts();
        }

        private void RefreshProducts()
        {
            State = new ProductsControlState() { Products = productsRepository.GetProducts() };
        }
    }
}
