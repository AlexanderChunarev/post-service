namespace Post.Application.Boundaries.Admin.Car
{
    public class CreateCarOutput
    {
        public string Model { get; set; }
        public string TypeName { get; set; }
        public CreateCarOutput(string model, string typeName)
        {
            Model = model;
            TypeName = typeName;
        }
    }
}