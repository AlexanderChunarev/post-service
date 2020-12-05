namespace Post.Application.Boundaries.Order
{
    public interface IOutputReceivingOrders : IErrorHandler
    {
        void Standard(CreateOrdersOutput outputs);
    }
}