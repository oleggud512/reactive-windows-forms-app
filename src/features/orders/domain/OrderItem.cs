using LiteDB;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.domain
{
    public class OrderItem
    {
        public OrderItem() 
        { 
            Product = new Product();
            Amount = 0;
        }
        public OrderItem(Product product)
        {
            Product = product;
            Amount = 0;
        }
        [System.ComponentModel.Browsable(false)]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ProductName { get => Product.Name; }
    }
}
