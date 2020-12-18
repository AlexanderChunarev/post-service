namespace Post.Application.Boundaries.Admin.Driver
{
    public interface ICreateDriverOutput : IErrorHandler
    {
        void Standard(CreateDriverOutput _output);
    }
}