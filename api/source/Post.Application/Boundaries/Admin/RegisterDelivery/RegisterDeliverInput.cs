namespace Post.Application.Boundaries.Admin.RegisterDelivery
{
    public class RegisterDeliveryInput
    {
        public double Weight { get; set; }
        public int OrderId { get; set; }
        public string StartPlace { get; set; }
        public string FinishPlace { get; set; }
        public int DriverId { get; set; }

        public RegisterDeliveryInput(double weight, int orderId, string startPlace, string finishPlace)
        {
            Weight = weight;
            OrderId = orderId;
            StartPlace = startPlace;
            FinishPlace = finishPlace;
        }

        public RegisterDeliveryInput()
        {
        }
    }
}