namespace Post.Application.Boundaries.Order
{
    public class CreateOrderOutput
    {
        public int SenderId {get; set;}
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public double Weight { get; set; } //вага укажеться адміністратором під час оформлення
        public string Status { get; set; }
        public CreateOrderOutput(int senderId, string recipientName, string recipientSurname, string recipientPhoneNumber, double weight, string status)
        {
            SenderId = senderId;
            RecipientName = recipientName;
            RecipientSurname = recipientSurname;
            RecipientPhoneNumber = recipientPhoneNumber;
            Weight = weight;
            Status = status;
        }
    }
}