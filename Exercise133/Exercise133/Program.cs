using System;
using System.Collections.Generic;
using Exercise133.Entities;

namespace Exercise133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char condition = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (condition == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (condition == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
