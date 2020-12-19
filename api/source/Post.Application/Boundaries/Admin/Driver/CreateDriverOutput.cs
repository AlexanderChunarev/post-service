namespace Post.Application.Boundaries.Admin.Driver
{
    using Post.Domain.Car;
    public class CreateDriverOutput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Car Car { get; set; }

        public CreateDriverOutput(string name, string surname, string phone, Car car)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Car = car;
        }
    }
}