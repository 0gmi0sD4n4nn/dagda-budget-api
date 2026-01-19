public class Query
{  
    public List<User> GetUser() => new()  
    {  
        new User { Id = 1, Username = "0gmi0s", Password = "Pa$$w0rd", CreateAt = new DateTime(2026,1,19,12,0,0) },  
        new User { Id = 2, Username = "0n1zuka", Password = "Str0ngPa$$w0rd", CreateAt = new DateTime(2026,1,19,11,0,0) }  
    };  
} 