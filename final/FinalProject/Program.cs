using System;
using System.Collections.Generic;

class Password
{
    public string Website { get; set; }
    public string EncryptedPassword { get; set; }

    public Password(string website, string password)
    {
        Website = website;
        // For simplicity, use XOR for basic encryption
        EncryptedPassword = Encrypt(password);
    }

    private string Encrypt(string input)
    {
        // For simplicity, use XOR for basic encryption
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)(chars[i] ^ 42); // XOR with a constant value (42 in this case)
        }
        return new string(chars);
    }

    public string Decrypt()
    {
        // For simplicity, decryption is the same as encryption
        return Encrypt(EncryptedPassword);
    }
}

class PasswordManager
{
    private List<Password> passwords;
    private string masterPassword;

    public PasswordManager(string masterPassword)
    {
        this.masterPassword = masterPassword;
        this.passwords = new List<Password>();
        LoadPasswords(); // Load passwords from file when the manager is created
    }

    public bool Authenticate(string enteredPassword)
    {
        return enteredPassword == masterPassword;
    }

    public void AddPassword(string website, string password)
    {
        Password newPassword = new Password(website, password);
        passwords.Add(newPassword);
        Console.WriteLine($"Password for {website} added successfully.");
        SavePasswords(); // Save passwords to file after adding a new password
    }

    public string GetPassword(string website)
    {
        Password password = passwords.Find(p => p.Website.Equals(website, StringComparison.OrdinalIgnoreCase));
        if (password != null)
        {
            return password.Decrypt();
        }
        else
        {
            return "Password not found.";
        }
    }

    private void SavePasswords()
    {
        // Save passwords to an encrypted text file
        using (StreamWriter writer = new StreamWriter("passwords.txt"))
        {
            foreach (var password in passwords)
            {
                writer.WriteLine($"{password.Website}:{password.EncryptedPassword}");
            }
        }
    }

    private void LoadPasswords()
    {
        // Load passwords from an encrypted text file
        if (File.Exists("passwords.txt"))
        {
            passwords.Clear();
            using (StreamReader reader = new StreamReader("passwords.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        passwords.Add(new Password(parts[0], parts[1]));
                    }
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Password Manager!");

        // Set a master password
        Console.Write("Enter master password: ");
        string enteredMasterPassword = Console.ReadLine();

        // Create an instance of PasswordManager
        PasswordManager passwordManager = new PasswordManager("mySecretPassword");

        // Authenticate the user
        if (passwordManager.Authenticate(enteredMasterPassword))
        {
            Console.WriteLine("Authentication successful.");

            // Menu
            while (true)
            {
                Console.WriteLine("\n1. Add a password");
                Console.WriteLine("2. Get a password");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter website: ");
                        string website = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();
                        passwordManager.AddPassword(website, password);
                        break;

                    case "2":
                        Console.Write("Enter website: ");
                        string searchWebsite = Console.ReadLine();
                        string retrievedPassword = passwordManager.GetPassword(searchWebsite);
                        Console.WriteLine($"Password: {retrievedPassword}");
                        break;

                    case "3":
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Authentication failed. Exiting the program.");
        }
    }
}