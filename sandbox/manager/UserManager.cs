using System.Collections.Generic;

public class UserManager
{
    private List<User> users;

    public UserManager()
    {
        users = new List<User>
        {
            new User { Username = "user", Password = "1" },
            new User { Username = "parker", Password = "2" },
            new User { Username = "jacob", Password = "3" }
        };
    }

    public User GetUser(string username)
    {
        return users.Find(u => u.Username == username);
    }
}