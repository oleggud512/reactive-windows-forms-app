using PrOOPz3.src.features.orders.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.presentation.add_order
{
    public class AddOrderFormParameters
    {
        public AddOrderFormParameters()
        {
            FormType = AddOrderFormType.Add;
        }

        public AddOrderFormType FormType { get; set; }
        public Order? OrderToEdit { get; set; }
    }
}
