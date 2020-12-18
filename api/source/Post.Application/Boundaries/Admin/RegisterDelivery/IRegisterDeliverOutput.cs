namespace Post.Application.Boundaries.Admin.RegisterDelivery
{   
    public interface IRegisterDeliveryOutput : IErrorHandler
    {
        void Standard(RegisterDeliveryOutput _output);
    }
}