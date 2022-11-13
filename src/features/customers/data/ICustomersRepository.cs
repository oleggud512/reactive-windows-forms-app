using PrOOPz3.src.features.customers.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.data
{
    public interface ICustomersRepository
    {
        public List<Customer> GetCustomers();
        public void AddCustomer(Customer customer);
        public void RemoveCustomer(Customer customer);
        public void RemoveCustomer(string id);
        public void UpdateCustomer(Customer customer);
        public void SaveCustomers(List<Customer> customers);
    }
}
