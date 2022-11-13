using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.data
{
    public class CustomersRepository : ICustomersRepository
    {
        public CustomersRepository() { }

        public List<Customer> GetCustomers()
        {
            return Serializer.DeserializeFromJSON<List<Customer>>("customers.json") ?? new List<Customer>(); ;
        }
        public void AddCustomer(Customer customer)
        {
            var customers = GetCustomers();
            customers.Add(customer);
            Utils.wl(customer);
            SaveCustomers(customers);
        }

        public void RemoveCustomer(Customer customer)
        {
            var customers = GetCustomers();
            customers.Remove(customer);
            SaveCustomers(customers);
        }

        public void RemoveCustomer(string id)
        {
            var customers = GetCustomers();
            customers.RemoveAt(customers.FindIndex((customer) => customer.Id == id));
            SaveCustomers(customers);
        }

        public void UpdateCustomer(Customer customer)
        {
            var customers = GetCustomers();
            int custIndex = customers.FindIndex((c) => c.Id == customer.Id);
            customers[custIndex] = customer;
            SaveCustomers(customers);
        }

        public void SaveCustomers(List<Customer> customers)
        {
            Serializer.SerializeToJSON(ref customers, "customers.json");
        }
    }
}
