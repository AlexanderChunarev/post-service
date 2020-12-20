using System.Collections.Generic;

namespace Post.Application.Boundaries.Order
{
    public interface IOutputReceivingOrders : IErrorHandler
    {
        void Standard(List<CreateOrdersOutput> outputs);
    }
}