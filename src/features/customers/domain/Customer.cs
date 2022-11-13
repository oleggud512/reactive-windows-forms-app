using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.customers.domain
{
    [DataContract]
    public class Customer
    {
        public Customer() { }
        public Customer(string id, string name, string phone, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }

        string id = Guid.NewGuid().ToString();
        string name = "";
        string phone = "";
        string address = "";

        [DataMember] public string Id { get { return id; } set { id = value.ToString(); } }
        [DataMember] public string Name { get { return name; } set { name = value; } }
        [DataMember] public string Phone { get { return phone; } set { phone = value; } }
        [DataMember] public string Address { get { return address; } set { address = value; } }

        public Customer CopyWith(string? id = null, string? name = null, string? phone = null, string? address = null)
        {
            return new Customer(
                id = id ?? this.id,
                name = name ?? this.name,
                phone = phone ?? this.phone,
                address = address ?? this.address
                );
        }
        [System.ComponentModel.Browsable(false)]
        public string StringRepr { get => ToString(); }

        public override string ToString()
        {
            return $"{Name}\nТел.: {Phone}\nАдреса: {Address}";
        }
    }
}
