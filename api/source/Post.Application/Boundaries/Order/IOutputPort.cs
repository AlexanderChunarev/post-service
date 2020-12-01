namespace Post.Application.Boundaries.Order
{
    public interface IOutputPort : IErrorHandler
    {
        void Standard(CreateOrderOutput output);
    }
}