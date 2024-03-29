﻿using PrOOPz3.src.features.orders.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.presentation.orders
{
    public class OrdersControlState
    {
        public OrdersControlState(List<Order>? orders = null) 
        {
            Orders = orders ?? new List<Order>();
        }

        public List<Order> Orders { get; }

        public OrdersControlState CopyWith(List<Order>? orders = null)
        {
            return new OrdersControlState(
                orders: orders ?? Orders
                );
        }
    }
}
