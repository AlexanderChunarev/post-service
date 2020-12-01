namespace Post.Domain.Order
{
    public class Order
    {
        public int Id { get; set; }
        public int SenderId {get; set;}
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPhonenumber { get; set; }
        public double Weight { get; set; } //вага укажеться адміністратором під час оформлення
        public string Status { get; set; }
    }
}