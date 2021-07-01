using System;
using Exercise123.Entities;
using Exercise123.Entities.Enums;

namespace Exercise123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order?: ");
            int itemQuant = int.Parse(Console.ReadLine());
            for (int i = 0; i < itemQuant; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                int productQuant = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuant, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("---- ORDER SUMMARY ----");
            Console.WriteLine(order.ToString());


        }
    }
}
