using PrOOPz3.src.features.customers.application;
using PrOOPz3.src.features.customers.data;
using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.presentation.customers
{
    public class CustomersControlController : StateObservable<CustomersControlState>, IDisposable
    {
        FilterCustomersService filterCustomersService;
        ICustomersRepository customersRepository;

        public CustomersControlController(
            FilterCustomersService filterCustomersService,
            ICustomersRepository customersRepository
            )
            : base(new CustomersControlState())
        {
            this.filterCustomersService = filterCustomersService;
            this.customersRepository = customersRepository;
            RefreshCustomers();
            Utils.wl($"Init CustomersControlController fresh customers = {State.Customers.Count()}");
        }

        public int CurrentIndex { set
            {
                State = new CustomersControlState() { Customers = State.Customers, CurrentIndex = value };
            }
        }

        public void AddCustomer(string name, string phone, string address)
        {
            customersRepository.AddCustomer(
                new Customer() { Name = name, Phone = phone, Address = address }
                );
            RefreshCustomers();
        }

        public void UpdateCustomer(
            string id, 
            string? name = null, 
            string? phone = null, 
            string? address = null
            )
        {
            var cust = State.Customers.First((c) => c.Id == id);
            Customer custToUpdate = cust.CopyWith(name: name, phone: phone, address: address);
            customersRepository.UpdateCustomer(custToUpdate); // TODO: возможно тут не будет обновляться вовсе из-за того что не будет распознавать их как одинаковые
            RefreshCustomers();
        }

        public void RemoveCustomer(string id)
        {
            customersRepository.RemoveCustomer(id);
            RefreshCustomers();
        }

        public void ToggleTodayFilter(bool isToday)
        {
            RefreshCustomers(isToday);
        }

        private async void RefreshCustomers(bool isToday = false) // could be more complex filtering / sorting
        {
            State = new CustomersControlState() { 
                Customers = isToday 
                    ? filterCustomersService.GetTodayCustomers() 
                    : customersRepository.GetCustomers() 
            };
        }

        public void Dispose()
        {
            Utils.wl("CustomersControlController().Dispose()");
        }
    }
}
