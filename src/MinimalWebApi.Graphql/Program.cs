using MinimalWebApi.Graphql;
using HotChocolate.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddSingleton<Repository>()
    .AddAuthentication().Services // Configure your Authentication here
    .AddAuthorization(o => o.AddPolicy("Librarian", p => p.RequireAssertion(_ => false)))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddAuthorization();

var app = builder.Build();

app.MapGraphQL();

app.Run();
