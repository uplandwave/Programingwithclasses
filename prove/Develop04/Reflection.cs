public class Reflection : Activity
{
    private string[] _prompts = { "Reflect on a time you last saw a duck", "Think about a time you gave a duck a sandwich"};
    private string[] _questions = { "Why do you care about this? ", "When was the last time you gave a duck bread?" };
    
    public Reflection() : base("Reflection", "This is a time for you to reflect on your life"){}

    public new void StartActivity()
    {
        base.StartActivity();
        int rando = new Random().Next(0, _prompts.Length);
        Console.WriteLine(_prompts[rando]);
        Console.WriteLine(_questions[rando]);
        base.EndActivity();
    }
}