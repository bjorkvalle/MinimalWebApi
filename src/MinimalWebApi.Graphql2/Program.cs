const string SpaceX = "spaceX";
const string StarWars = "starWars";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient(SpaceX, c => c.BaseAddress = new Uri("https://api.spacex.land/graphql/"));
builder.Services.AddHttpClient(StarWars, c => c.BaseAddress = new Uri("https://swapi-graphql.netlify.app/.netlify/functions/index"));

builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema(SpaceX)
    .AddRemoteSchema(StarWars)
    //.AddQueryType<Query>()
    ;

var app = builder.Build();

app.MapGraphQL();

app.Run();
