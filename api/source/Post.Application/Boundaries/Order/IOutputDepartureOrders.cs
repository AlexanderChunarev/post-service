namespace Post.Application.Boundaries.Order
{
    public interface IOutputDepartureOrders : IErrorHandler
    {
        void Standard(CreateOrdersOutput outputs);
    }
}