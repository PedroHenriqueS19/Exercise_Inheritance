using System;
using Exercise_Inheritance.Entities.Produtcs;
using Exercise_Inheritance.Entities.Produtcs.ImportedProduct;
using Exercise_Inheritance.Entities.Produtcs.UsedProduct;

namespace Exercise_Inheritance
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Products> product = new List<Products>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write($"Commom, Used or Imported (c,u,i): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Price: ");
                double price = double.Parse(Console.ReadLine());
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write($"Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProducts(name, price, customsFee));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write($"Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProducts(name, price, manufactureDate));
                }
                else
                {
                    product.Add(new Products(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine($"PRICE TAGS: ");
            foreach (Products prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            } 
        }
    }
}