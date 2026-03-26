namespace UserClass;

public class User
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public int Balance { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        Balance = 0;
    }
}
