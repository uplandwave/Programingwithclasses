using System;
using System.Collections.Generic;

class PasswordManager
{
    static void Main()
    {
        UserManager userManager = new UserManager();
        PasswordManagerApp app = new PasswordManagerApp(userManager);

        while (true)
        {
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        app.Login();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not an Option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class UserManager
{
    private List<User> users;

    public UserManager()
    {
        users = new List<User>
        {
            new User { Username = "user1", Password = "1" },
            new User { Username = "user2", Password = "2" }
        };
    }

    public User GetUser(string username)
    {
        return users.Find(u => u.Username == username);
    }
}

class PasswordManagerApp
{
    private UserManager userManager;
    private User currentUser;
    private List<string> passwords;

    public PasswordManagerApp(UserManager userManager)
    {
        this.userManager = userManager;
        this.passwords = new List<string>();
    }

    public void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        currentUser = userManager.GetUser(username);

        if (currentUser != null && currentUser.Password == password)
        {
            Console.WriteLine($"Welcome to Hell, {currentUser.Username}!");
            ShowMenu();
        }
        else
        {
            Console.WriteLine("Wrong Wrong Wrong. Try again when you're brain works.");
        }
    }

    private void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Add New Password");
            Console.WriteLine("2. Generate Random Password");
            Console.WriteLine("3. View All Passwords");
            Console.WriteLine("4. Remove Password");
            Console.WriteLine("5. Log Out");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddPassword();
                        break;
                    case 2:
                        GenerateRandomPassword();
                        break;
                    case 3:
                        ViewAllPasswords();
                        break;
                    case 4:
                        RemovePassword();
                        break;
                    case 5:
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private void AddPassword()
    {
        Console.Write("Enter new password: ");
        string newPassword = Console.ReadLine();
        passwords.Add(newPassword);
        Console.WriteLine("Password added successfully.");
    }

    private void GenerateRandomPassword(){
        Console.Write("Enter the number of digits: ");
        int lang = int.Parse(Console.ReadLine());

        string randomPassword = GenerateRandomString(lang);
        // Console.WriteLine($"Random String: {randomPassword}");

        static string GenerateRandomString(int lang){
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";

        char[] randomArray = new char[lang];

        for (int i = 0; i < lang; i++){
            randomArray[i] = chars[random.Next(chars.Length)];
        }

        return new string(randomArray);
        }

        passwords.Add(randomPassword);
        Console.WriteLine($"Generated Password: {randomPassword}");
    }

    private void ViewAllPasswords()
    {
        Console.WriteLine("All Passwords:");
        foreach (var password in passwords)
        {
            Console.WriteLine(password);
        }
    }

    private void RemovePassword()
    {
        Console.Write("Enter the password to remove: ");
        string passwordToRemove = Console.ReadLine();
        if (passwords.Contains(passwordToRemove))
        {
            passwords.Remove(passwordToRemove);
            Console.WriteLine("Password removed successfully.");
        }
        else
        {
            Console.WriteLine("Password not found.");
        }
    }
}