namespace Blog.Entities
{
    public record Article
    {
        public Guid Id { get; init; }
        public DateTimeOffset PostDate { get; init; }
        public string Title { get; init; } = "";
        public string Subtitle { get; init; } = "";
        public string Body { get; init; } = "";
    }
}