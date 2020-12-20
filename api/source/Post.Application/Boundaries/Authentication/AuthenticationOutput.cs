namespace Post.Application.Boundaries.Authentication
{
    public class AuthenticationOutput
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Token { get; set; }

        public AuthenticationOutput(int id, string firstName, string lastName, string email, string phone, string token)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phone;
            Token = token;
        }

        public AuthenticationOutput()
        {
        }
    }
}