using LiteDB;
using Microsoft.VisualBasic;
using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.domain
{
    [DataContract]
    public class Order
    {
        public const string Format = "d";

        public Order() 
        {
            Id = 0;
            Date = DateTime.Now;
            OrderItems = new List<OrderItem>();
        }

        [DataMember] 
        public int Id { get; set; }
        
        [DataMember] 
        public DateTime Date { get; set; }
         
        [BsonIgnore] 
        public string DateStr { get { return Date.ToString(Format); } set { Date = DateTime.Parse(value); } }
        [BsonIgnore]
        public string StringRepr { 
            get => $"{Id} | {DateStr}\n" +
                $"Клієнт: {Customer?.Name ?? "has no name.."}\n" +
                $"Товари: {String.Join(", ", OrderItems.Select((item) => item.Product.Name))}."; 
        }


        [DataMember] 
        public List<OrderItem> OrderItems { get; set; }
        
        [DataMember] 
        public Customer? Customer { get; set; }

        public Order CopyWith(
            int? id = null, 
            DateTime? date = null, 
            List<OrderItem>? products = null, 
            Customer? customer = null
            )
        {
            return new Order()
            {
                Id = id ?? this.Id,
                Date = date ?? this.Date,
                OrderItems = products ?? this.OrderItems,
                Customer = customer ?? this.Customer,
            };
        }

        public bool Exists()
        {
            return Id > 0;
        }

        public bool CanAdd()
        {
            return Customer != null && OrderItems.Count() > 0;
        }
    }
}
