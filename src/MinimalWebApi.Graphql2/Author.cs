namespace MinimalWebApi.Graphql2
{
    public record Author(int Id, string? Name)
    {
        public List<Book>? Books { get; init; }
    }
}
