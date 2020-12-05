namespace Post.Application.Boundaries.Order
{
    public class GetOrdersInput 
    {
        public int SenderId { get; set; }
        public string Phone { get; set; }
        
        public GetOrdersInput(int senderId)
        {
            SenderId = senderId;
        }

        public GetOrdersInput(string phone)
        {
            Phone = phone;
        }
    }
}