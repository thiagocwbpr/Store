using System;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal price, int quantity)
        {
            Product = product;
            Price = Product != null ? product.Price : 0; // <- Se o produto for nulo, já define o valor como 0.
            Quantity = quantity;
        }
        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}