using DagdaBudgetAPI.DataBaseAccess;
using DagdaBudgetAPI.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add GraphQL services
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL();

app.Run();
