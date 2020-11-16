using Airport.Application.Boundaries;

namespace Post.Application.Boundaries.Example
{
    public interface IOutputPort : IErrorHandler
    {
         void Standard();
    }
}