using PrOOPz3.src.features.customers.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.presentation.customer_picker
{
    public class CustomerPickerFormState
    {
        public CustomerPickerFormState() 
        {
            Customers = new List<Customer>();
            Query = "";
        }

        public List<Customer> Customers { get; set; }
        public string Query { get; set; }
    }
}
