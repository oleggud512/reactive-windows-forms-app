using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.presentation
{
    public class ProductsControlState
    {
        public ProductsControlState()
        {
            Products = new List<Product>();
            CurrentIndex = 0;
        }

        public List<Product> Products { get; set; }
        public int CurrentIndex { get; set; }
        public Product CurrentProduct
        {
            get
            {
                return Products[CurrentIndex];
            }
        }
    }
}
