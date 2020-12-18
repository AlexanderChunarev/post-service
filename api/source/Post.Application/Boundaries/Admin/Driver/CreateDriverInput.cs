namespace Post.Application.Boundaries.Admin.Driver
{
    public class CreateDriverInput 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone  { get; set; }
        public int CarId { get; set; }

        public CreateDriverInput(string name, string surname, string phone, int carId)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            CarId = carId;
        }

        public CreateDriverInput()
        {
        }
    }
}