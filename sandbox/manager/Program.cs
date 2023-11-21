class Program
{
    static void Main()
    {
        UserManager userManager = new UserManager();
        PasswordManagerApp instance = new PasswordManagerApp(userManager);
        instance.Run();
    }
}