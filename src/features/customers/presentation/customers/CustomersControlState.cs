using PrOOPz3.src.features.customers.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.presentation.customers
{
    public class CustomersControlState
    {
        public CustomersControlState() 
        {
            Customers = new List<Customer>();
            CurrentIndex = 0;
        }

        public List<Customer> Customers { get; set; }
        public int CurrentIndex { get; set; }

        public Customer CurrentCustomer { get
            {
                return Customers[CurrentIndex];
            } 
        }
    }
}
