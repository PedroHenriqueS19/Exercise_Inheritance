using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Entities.Produtcs.ImportedProduct
{
    internal class ImportedProducts : Products
    {
        public double CustomsFee { get; set; }

        public ImportedProducts()
        {
        }

        public ImportedProducts(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return $"Product: {Name}, Total : ${TotalPrice():f2} (Customs fee: {CustomsFee:f2})";
        }
    }
}
