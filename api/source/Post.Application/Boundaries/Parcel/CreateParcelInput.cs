namespace Post.Application.Boundaries.Parcel
{
    public class CreateParcelInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public CreateParcelInput(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public CreateParcelInput()
        {
        }
    }
}