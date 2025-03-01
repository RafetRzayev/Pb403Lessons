namespace StoreManagment;

public class User
{
    private static int _autoIncrementId = 34;

    public User(string username, string password, Role role, decimal balance = 60550)
    {
        Username = username;
        Password = password;
        Role = role;
        Id = _autoIncrementId++;
        Balance = balance;
    }

    public int Id { get; }
    public string Username { get; }
    public string Password { get; }
    public Role Role { get; }
    public decimal Balance { get; }
}

public enum Role
{
    Admin,
    Client
}
