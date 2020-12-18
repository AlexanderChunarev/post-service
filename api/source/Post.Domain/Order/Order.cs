namespace Post.Domain.Order
{
    using Post.Domain.Parcel;
    public class Order
    {
        public int Id { get; set; }
        public int SenderId {get; set;}
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhonenumber { get; set; }
        public int ParcelId { get; set; }
        public string Status { get; set; }
    }
}