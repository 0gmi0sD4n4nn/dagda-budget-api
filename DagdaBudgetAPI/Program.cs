var builder = WebApplication.CreateBuilder(args);  

// Add GraphQL services  
builder.Services  
    .AddGraphQLServer()  
    .AddQueryType<Query>();  

var app = builder.Build();  

// Map GraphQL endpoint  
app.MapGraphQL();  

app.Run();  
