public class PasswordManagerApp : BaseApp
{

    
    
    public PasswordManagerApp(UserManager userManager) : base(userManager){

    }

    public override void Run()
    {
        base.Run();
    }

    public override void mainMenu()
    {
        while (true)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add New Password");
            Console.WriteLine("2. Generate Random Password");
            Console.WriteLine("3. View All Passwords");
            Console.WriteLine("4. Remove Password");
            Console.WriteLine("5. Save Passwords?");
            Console.WriteLine("6. Load Passwords?");
            Console.WriteLine("7. Exit");
            Console.WriteLine("==============================");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {   
                Handler handler = new Handler(userManager);
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
                        handler.Save();
                        Console.WriteLine("Your passwords have been saved");
                        break;
                    case 6:
                        handler.Load();
                        Console.WriteLine("Your passwords have been loaded");
                        break;
                    case 7:
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Invalid. You might be gay.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
