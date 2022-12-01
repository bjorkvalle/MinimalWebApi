namespace MinimalWebApi.RecordsPlayground
{
    record User(string username, bool isPremium)
    {
        public int Age { get; init; }
    }
}
