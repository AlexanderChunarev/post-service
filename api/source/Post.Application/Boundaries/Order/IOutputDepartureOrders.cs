namespace Post.Application.Boundaries.Order
{
    public interface IOutputSendedOrders : IErrorHandler
    {
        void Standard(CreateOrdersOutput outputs);
    }
}