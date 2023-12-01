using System;
using System.Collections.Generic;

public abstract class BaseApp
{
    public List<Text> passwords = new List<Text>();
    protected UserManager userManager;
    protected User currentUser;
    


    public BaseApp(UserManager userManager)
    {
        this.userManager = userManager;
        // this.passwords = new List<string>();
        // this.passwords = new List<Text>();
    }

    public virtual void Run()
    {
        while (true)
        {
            Console.WriteLine("==================");
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Exit");
            Console.WriteLine("==================");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not quite. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }

    protected void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        currentUser = userManager.GetUser(username);

        if (currentUser != null && currentUser.Password == password)
        {
            Console.Clear();
            Console.WriteLine($"Welcome, {currentUser.Username}!");
            Load();
            mainMenu();
        }
        else
        {
            Console.WriteLine("Invalid username or password. Try again.");
        }
    }

    public abstract void mainMenu();


    protected virtual void AddPassword()
    {
        Console.Write("Enter site: ");
        string newSite = Console.ReadLine();        
        Console.Write("Enter new password: ");
        string newPassword = Console.ReadLine();
        AddEntry(newPassword, newSite);
        Console.WriteLine("Password added successfully.");
        Console.WriteLine($"{newPassword}{newSite}");
    }
        public void AddEntry(string newPassword, string newSite) {
        Text text = new Text(newPassword,newSite);
        // text._password = newPassword;
        // text._site = newSite;
        // Console.WriteLine($"{newPassword}{newSite}");
        passwords.Add(text);
    }

    protected void GenerateRandomPassword(){
        Console.Write("Enter the number of digits: ");
        int lang = int.Parse(Console.ReadLine());
        Console.Write("What site is this for: ");
        string newSite = Console.ReadLine();        


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

        // passwords.Add(randomPassword);        
        AddEntry(randomPassword, newSite);
        Console.WriteLine($"Generated Password: {randomPassword}");
        Console.WriteLine("Password Added to Vault");
    }

    protected virtual void ViewAllPasswords()
    {
        Console.Clear();
        Console.WriteLine("All Passwords:");
        foreach (var password in passwords)
        {
            password.Display();
            Console.WriteLine();

        }
    }

    protected virtual void RemovePassword()
    {
        // Console.Write("Enter the password to remove: ");
        // string passwordToRemove = Console.ReadLine();
        // if (passwords.Contains(passwordToRemove))
        // {
        //     passwords.Remove(passwordToRemove);
        //     Console.WriteLine("Password removed successfully.");
        // }
        // else
        // {
        //     Console.WriteLine("Password not found.");
        // }
    }
        public void Load(){
        StreamReader new_reader = new StreamReader($"{currentUser}.txt");
        while (!new_reader.EndOfStream)
        {
            string password = new_reader.ReadLine();
            string site = new_reader.ReadLine();    
            Text text = new Text(password, site);
            passwords.Add(text);
        }
    }

}