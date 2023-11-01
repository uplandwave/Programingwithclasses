public class Reflection : Activity
{
    private string[] _prompts = { "Reflect on a time you last saw a duck", "Think about a time you gave a duck a sandwich"};
    private string[] _questions = { "Why do you care about this? ", "When was the last time you gave a duck bread?" };
    
    public Reflection() : base("Reflection", "This is a time for you to reflect on your life"){}

    public void StartActivity()
    {
        base.StartBace();
        Console.Clear();
        int rando = new Random().Next(0, _prompts.Length);
        Console.WriteLine("Reflect on these nuts");
        base.countDown();
        Console.WriteLine(_prompts[rando]);
        Thread.Sleep(_mathTime/3);
        Console.WriteLine(_questions[1]);
        Thread.Sleep(_mathTime/3);
        Console.WriteLine(_questions[0]);
        Thread.Sleep(_mathTime/3);
        base.EndActivity();
        base.countDown();


    }
}