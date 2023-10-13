using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Entities.OrderAggregate;

namespace server.DTOs
{
    public class CreateOrderDto
    {
        public bool SaveAddress { get; set; }
        public ShippingAdress ShippingAddress { get; set; }
    }
}