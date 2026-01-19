public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime ArchivedAt { get; set; }
}