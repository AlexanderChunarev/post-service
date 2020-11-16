namespace Post.Application.Boundaries.Example
{
    public class ExampleInput
    {
        public string Title { get; set; }

        public ExampleInput(string title)
        {
            Title = title;
        }
    }
}