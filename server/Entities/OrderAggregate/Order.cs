using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Entities.OrderAggregate
{
    public class Order
    {
        public int Id { get; set; }
        public string BuyerId{ get; set; }
        public ShippingAdress ShippingAdress { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderItems> OrderItems { get; set; }
        public long Subtotal { get; set; }
        public long DeliveryFee { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public long GetTotal()
        {
            return Subtotal + DeliveryFee;
        }
    }
}