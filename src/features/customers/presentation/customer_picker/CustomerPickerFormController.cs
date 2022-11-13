using PrOOPz3.src.features.customers.data;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.presentation.customer_picker
{
    public class CustomerPickerFormController : StateObservable<CustomerPickerFormState>
    {
        ICustomersRepository customersRepository;

        public CustomerPickerFormController(ICustomersRepository customersRepository) 
            : base(new CustomerPickerFormState())
        {
            this.customersRepository = customersRepository;
            RefreshCustomers();
        }

        public void RefreshCustomers(string query = "")
        {
            Utils.wl($"from debouncer = {query}");
            State = new CustomerPickerFormState()
            {
                Query = query,
                Customers = customersRepository.GetCustomers()
                    .Where(c => c.Name.Contains(query)).ToList() // TODO: could add more complex search.
            };
        }
    }
}
