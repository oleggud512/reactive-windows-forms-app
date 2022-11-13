using PrOOPz3.src.features.orders.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.data
{
    public interface IOrdersRepository : IDisposable
    {
        public List<Order> GetOrders();
        public void RemoveOrder(int id);
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public void SaveOrders(List<Order> orders);
    }
}
