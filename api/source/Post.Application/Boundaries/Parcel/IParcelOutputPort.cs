namespace Post.Application.Boundaries.Parcel
{
    public interface IParcelOutputPort : IErrorHandler
    {
        void Standard(CreateParcelOutput _output);
    }
}