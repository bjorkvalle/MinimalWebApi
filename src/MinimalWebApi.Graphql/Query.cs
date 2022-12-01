namespace MinimalWebApi.Graphql
{ 
    public class Query
    {
        public string Hello() => "World";

        public Task<List<Book>> GetBooks([Service] Repository repository) =>
            repository.GetBooksAsync();
    }
}
