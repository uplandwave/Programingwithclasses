public class Activity {
    protected string _name;
    protected string _description;
    protected int _time;
    protected int _mathTime;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public void StartBace(){
        Console.Clear();
        spin();
        Console.Clear();
        Console.WriteLine($"{_name}: {_description}");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine($"You picked the {_name} activity. How long do you want to do it for?");
        Console.Write("Put time in seconds Ex. 10 : ");
        _time = int.Parse(Console.ReadLine());
        _mathTime = _time * 1000;
        Console.WriteLine();
    }

    public void EndActivity() {
        Console.WriteLine();
        Console.WriteLine($"You did the {_name} activity for {_time} seconds!");
        Console.WriteLine();

    }
    public void countDown(){
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("0");
        Console.Write("\b \b");
    }
    public void spin(){
        Console.Write("|");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(100);
    }
}