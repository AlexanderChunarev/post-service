namespace Post.Application.Boundaries
{
    public interface IErrorHandler
    {
        void Error(string message);
    }
}