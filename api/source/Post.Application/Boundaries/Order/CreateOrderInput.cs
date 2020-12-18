namespace Post.Application.Boundaries.Order
{
    public class CreateOrderInput
    {
        public int SenderId {get; set;}
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public int ParcelId { get; set; }
        public string Status { get; set; }

        public CreateOrderInput(int senderId, string recipientName, string recipientSurname, string recipientPhoneNumber, int parcelId, string status)
        {
            SenderId = senderId;
            RecipientName = recipientName;
            RecipientSurname = recipientSurname;
            RecipientPhoneNumber = recipientPhoneNumber;
            ParcelId = parcelId;
            Status = status;
        }

        public CreateOrderInput()
        {

        }
    }
}