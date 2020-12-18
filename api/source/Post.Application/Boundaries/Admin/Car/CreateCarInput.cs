namespace Post.Application.Boundaries.Admin.Car
{
    public class CreateCarInput
    {
        public string Model { get; set; }
        public string TypeName { get; set; }
        
        public CreateCarInput(string model, string typeName)
        {
            Model = model;
            TypeName = typeName;
        }
        public CreateCarInput()
        {
        }
    }
}