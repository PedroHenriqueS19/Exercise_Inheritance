using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_Inheritance.Entities.Produtcs.UsedProduct
{
    internal class UsedProducts : Products
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProducts()
        {
        }

        public UsedProducts(string name, double price,DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return $"Product: {Name} (used), Total price: ${Price:f2}, (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
