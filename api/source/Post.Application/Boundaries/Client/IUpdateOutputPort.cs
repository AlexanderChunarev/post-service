namespace Post.Application.Boundaries.Client
{
    public interface IUpdateOutputPort : IErrorHandler
    {
        void Standard(CreateClientOutput output);
    }
}