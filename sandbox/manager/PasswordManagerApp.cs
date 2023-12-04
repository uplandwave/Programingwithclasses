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
            Console.WriteLine("5. Save Passwords");
            Console.WriteLine("6. Exit");
            Console.WriteLine("==============================");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {   
                Handler handler = new Handler(userManager,passwords,currentUser);
                PasswordNuke nuke = new PasswordNuke();
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
                        Console.WriteLine("This feature is not yet available. Please purchase the next DLC to gain access");
                        break;
                    case 5:
                        handler.Save();
                        Console.WriteLine("Your passwords have been saved");
                        break;
                    case 6:
                        currentUser = null;
                        return;
                    case 7:
                        int opt;
                        Console.Clear();
                        Console.WriteLine("\n** Are you sure you want to proceed? **");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nI can no longer follow you down this path...");
                        Console.WriteLine("\n1: Yes \n2: No");
                        if (int.TryParse(Console.ReadLine(), out opt))
                            switch(opt){
                                case 1:
                                    Console.WriteLine("You may not have a brain, gentlemen, but you have an idea.");
                                    nuke.TheBigOne();
                                    nuke.LaunchSequence();
                                    nuke.NukeDisplay();
                                break;
                                case 2:
                                    Console.WriteLine("Okay, someone set the terror level to Code Brown, because I need to change my pants!\n-President Hathaway");
                                break;
                            }
                            break;

                        
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
