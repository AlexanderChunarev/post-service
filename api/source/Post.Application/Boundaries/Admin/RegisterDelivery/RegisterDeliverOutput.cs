namespace Post.Application.Boundaries.Admin.RegisterDelivery
{
    using Post.Domain.Driver;
    using Post.Domain.Order;
    public class RegisterDeliveryOutput
    {
        public Order Order { get; set; }
        public Driver Driver { get; set; }
        public string StartPlace { get; set; }
        public string FinishPlace { get; set; }

        public RegisterDeliveryOutput(Order order, Driver driver, string startPlace, string finishPlace)
        {
            Order = order;
            Driver = driver;
            StartPlace = startPlace;
            FinishPlace = finishPlace;
        }
    }
}