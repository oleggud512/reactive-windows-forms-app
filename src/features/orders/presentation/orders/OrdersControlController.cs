using PrOOPz3.src.features.orders.data;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.presentation.orders
{
    public class OrdersControlController : StateObservable<OrdersControlState>
    {
        IOrdersRepository ordersRepository;
        public OrdersControlController(IOrdersRepository ordersRepository) 
            : base(new OrdersControlState())
        {
            this.ordersRepository = ordersRepository;
            RefreshOrders();
        }

        public void RefreshOrders()
        {
            State = State.CopyWith(orders: ordersRepository.GetOrders());
        }
    }
}
