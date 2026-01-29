using DagdaBudgetAPI.DataBaseAccess;
using DagdaBudgetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DagdaBudgetAPI.Queries;

public class Query
{
    private readonly ApplicationDbContext applicationDbContext;

    public Query(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }

    public IQueryable<User> GetUsers([Service] IDbContextFactory<ApplicationDbContext> factory)
    {
        return factory.CreateDbContext().Users;
    }
}
