using System.ComponentModel.DataAnnotations.Schema;

namespace DagdaBudgetAPI.Models;

[Table("User")]
public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArchivedAt { get; set; }
}
