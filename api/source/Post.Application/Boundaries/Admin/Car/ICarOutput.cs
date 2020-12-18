namespace Post.Application.Boundaries.Admin.Car
{
    public interface ICarOutput : IErrorHandler
    {
        void Standard(CreateCarOutput _output);
    }
}