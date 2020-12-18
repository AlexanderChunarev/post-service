namespace Post.Application.Boundaries.Authentication
{
    public interface IOutputPort : IErrorHandler
    {
        void Standard(AuthenticationOutput output);
    }
}