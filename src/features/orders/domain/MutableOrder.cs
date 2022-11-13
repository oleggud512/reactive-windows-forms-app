using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.domain
{
    public static class MutableOrder
    {
        public static Order AddProduct(this Order order, Product product)
        {
            if (order.OrderItems.Any(item => item.Product.Id == product.Id)) return order;
            List<OrderItem> newItems = order.OrderItems.Select((item) => item).ToList();
            newItems.Add(new OrderItem(product));
            return order.CopyWith(products: newItems);
        }

        public static Order RemoveProduct(this Order order, Product product)
        {
            List<OrderItem> newItems = order.OrderItems.Select((item) => item).ToList();
            newItems.Remove(newItems.First((item) => item.Product == product));
            return order.CopyWith(products: newItems);
        }

        public static Order SetCustomer(this Order order, Customer customer)
        {
            return order.CopyWith(customer: customer);
        }

        public static Order SetDate(this Order order, DateTime date)
        {
            return order.CopyWith(date: date.Date);
        }
    }
}
