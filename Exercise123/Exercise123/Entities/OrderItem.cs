using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise123.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"Products: {Product.ToString()}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}"; 
        }
    }
}
