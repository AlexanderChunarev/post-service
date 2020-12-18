namespace Post.Domain.Delivery
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DriverId { get; set; }
        public string StartPlace { get; set; }
        public string FinishPlace { get; set; }
    }
}