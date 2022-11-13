using PrOOPz3.src.features.customers.data;
using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.orders.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.application
{
    public class FilterCustomersService
    {
        ICustomersRepository customersRepository;
        IOrdersRepository ordersRepository;
        
        public FilterCustomersService(ICustomersRepository customersRepository, IOrdersRepository ordersRepository)
        {
            this.customersRepository = customersRepository;
            this.ordersRepository = ordersRepository;
        }

        public List<Customer> GetTodayCustomers()
        {
            return ordersRepository.GetOrders()
                .Where((order) => order.Date.Date == DateTime.Now.Date)
                .Select((order) => order.Customer!)
                .GroupBy((customer) => customer.Id)
                .Select((group) => group.First())
                .ToList();
        }
    }
}
