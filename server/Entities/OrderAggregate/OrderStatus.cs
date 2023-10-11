using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        Pending,
        PaymentRecevied,
        PaymentFailed,
    }
}