using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Entities.OrderAggregate
{
    public class OrderItems
    {
        public int Id { get; set; }
        public ProductItemOrder ItemOrdered { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
    }
}