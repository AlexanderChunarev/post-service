namespace Post.Application.Boundaries.Client
{
    using Post.Domain.Client;
    public class CreateClientOutput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }   

        public CreateClientOutput(string name, string surname, string phoneNumber, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}