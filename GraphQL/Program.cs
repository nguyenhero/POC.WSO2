using GraphQL.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddGraphQLServer()
        .AddQueryType<Query>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseRouting().UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});
///ui/graphiql
app.UseGraphQLGraphiQL();
//ui/altair
app.UseGraphQLAltair();
//ui/playground
app.UseGraphQLPlayground();
//ui/voyager
app.UseGraphQLVoyager();
app.Run();
