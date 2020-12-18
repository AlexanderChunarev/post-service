namespace Post.Application.Boundaries.Order
{
    public class CreateOrderInput
    {
        public int SenderId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public string ParcelName { get; set; }
        public string ParcelDescription { get; set; }
        public string Status { get; set; }
        public CreateOrderInput(int senderId, string recipientName, string recipientSurname, string recipientPhoneNumber, string parcelName, string parcelDescription, string status)
        {
            SenderId = senderId;
            RecipientName = recipientName;
            RecipientSurname = recipientSurname;
            RecipientPhoneNumber = recipientPhoneNumber;
            ParcelName = parcelName;
            ParcelDescription = parcelDescription;
            Status = status;
        }

        public CreateOrderInput()
        {

        }
    }
}