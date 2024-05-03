using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Entities.Produtcs
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {
        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"Product: {Name}, Total price: ${Price:f2}";
        }
    }
}
