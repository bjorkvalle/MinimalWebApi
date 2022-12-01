namespace MinimalWebApi.Graphql2
{
    public class Query
    {
        // resolvers
        
        public Book GetBook() => new Book("C# in Depth", "Jon Skeet");

        public IQueryable<Book> GetBooks() => new List<Book>()
            {
                GetBook()
            }
            .AsQueryable();
    }
}
