namespace Post.Application.Boundaries.Parcel
{
    public class CreateParcelOutput
    {
        public int Id { get; set; }

        public CreateParcelOutput(int id)
        {
            Id = id;
        }

    }
}