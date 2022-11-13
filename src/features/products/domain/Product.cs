using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.products.domain
{
    [DataContract]
    public class Product
    {
        public Product() 
        {
            Name = "";
        }
        
        [DataMember] public int Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public double Price { get; set; }
        [DataMember] public double Weight { get; set; }

        public Product CopyWith(
            int? id = null, 
            string? name = null, 
            double? price = null, 
            double? weight = null
            )
        {
            return new Product()
            {
                Id = id ?? Id,
                Name = name ?? Name,
                Price = price ?? Price,
                Weight = weight ?? Weight
            };
        }
    }
}
