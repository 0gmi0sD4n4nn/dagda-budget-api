using DagdaBudgetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DagdaBudgetAPI.DataBaseAccess;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
