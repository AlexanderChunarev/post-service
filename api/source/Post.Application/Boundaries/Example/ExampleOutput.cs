namespace Post.Application.Boundaries.Example
{
    public class ExampleOutput
    {
        public string Title { get; set; }

        public ExampleOutput(string title)
        {
            this.Title = title;
        }
    }
}