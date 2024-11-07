using NodeIdIssue;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddGlobalObjectIdentification()
    .AddType<MyThingType>()
    .AddQueryType<QueryType>()
    .AddMutationType<MutationType>();

var app = builder.Build();
app.MapGraphQL();

await app.RunAsync();