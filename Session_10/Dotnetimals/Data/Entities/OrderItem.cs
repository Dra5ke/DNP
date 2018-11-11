using System;

namespace Dotnetimals
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Cat Cat { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}