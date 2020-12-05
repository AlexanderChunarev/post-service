using System.Collections;
using System.Collections.Generic;

namespace Post.Application.Boundaries.Order
{
    using Post.Domain.Order;
    public class CreateOrdersOutput
    {
        public List<Order> Orders { get; set; }

        public CreateOrdersOutput(List<Order> orders)
        {
            Orders = orders;
        }

    }
}