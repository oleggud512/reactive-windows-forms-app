using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrOOPz3.src.features.orders.domain;
using LiteDB;
using PrOOPz3.src.utils;
using Microsoft.Extensions.Configuration;

namespace PrOOPz3.src.features.orders.data
{
    public class OrdersRepository : IOrdersRepository
    {
        LiteDatabase conn;
        ILiteCollection<Order> ordersCollection;


        public OrdersRepository(LiteDatabase conn) {
            this.conn = conn;
            ordersCollection = conn.GetCollection<Order>("orders");
        }

        public List<Order> GetOrders()
        {
            return ordersCollection.Query().Include("$.OrderItems[*].Product").ToList();
        }

        public void AddOrder(Order order)
        {
            ordersCollection.Insert(order);
        }

        public void RemoveOrder(int id)
        {
            ordersCollection.Delete(id);
        }

        public void UpdateOrder(Order order)
        {
            ordersCollection.Update(order);
        }

        public void SaveOrders(List<Order> orders)
        {
            ordersCollection.DeleteAll();
            foreach (var order in orders) ordersCollection.Insert(order);
        }

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
