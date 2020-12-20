using System.Collections;
using System.Collections.Generic;

namespace Post.Application.Boundaries.Order
{
    using Post.Domain.Driver;
    using Post.Domain.Order;
    using Post.Domain.Parcel;
    using Post.Domain.User;

    public class CreateOrdersOutput
    {
        public int OrderId { get; set; }
        public User User { get; set; }
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public Parcel Parcel { get; set; }
        public string Status { get; set; }
         public CreateOrdersOutput(int orderId, User user, string recipientName, string recipientSurname, Parcel parcel, string status)
        {
            OrderId = orderId;
            User = user;
            RecipientName = recipientName;
            RecipientSurname = recipientSurname;
            Parcel = parcel;
            Status = status;
        }
    }
}