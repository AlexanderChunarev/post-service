using Post.Domain.Parcel;

namespace Post.Application.Boundaries.Order
{
    public class CreateOrderOutput
    {
        public int SenderId {get; set;}
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public Parcel Parcel { get; set; }
        public string Status { get; set; }
        public CreateOrderOutput(int senderId, string recipientName, string recipientSurname, string recipientPhoneNumber, Parcel parcel, string status)
        {
            SenderId = senderId;
            RecipientName = recipientName;
            RecipientSurname = recipientSurname;
            RecipientPhoneNumber = recipientPhoneNumber;
            Parcel = parcel;
            Status = status;
        }
        
    }
}