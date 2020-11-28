namespace Post.Application.Boundaries.Client
{
    public interface IOutputPort : IErrorHandler
    {
        void Standard(CreateClientOutput output);
    }
}