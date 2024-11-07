using CostAnalysisIssue;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddGlobalObjectIdentification()
    .AddType<MyThingType>()
    .AddQueryType<QueryType>();

var app = builder.Build();
app.MapGraphQL();

await app.RunAsync();