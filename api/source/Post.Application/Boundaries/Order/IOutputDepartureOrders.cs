using System.Collections.Generic;

namespace Post.Application.Boundaries.Order
{
    public interface IOutputSendedOrders : IErrorHandler
    {
        void Standard(List<CreateOrdersOutput> outputs);
    }
}