using System;
using System.Collections.Generic;
using System.Text;
using Exercise123.Entities.Enums;

namespace Exercise123.Entities
{
    class Order
    {
        public DateTime Moment { get; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.UtcNow;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToLocalTime());
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach (OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
