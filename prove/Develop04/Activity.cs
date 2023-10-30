public class Activity {
    protected string _name;
    protected string _description;
    protected int _time;
    protected int _mathTime;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
        public void StartActivity(){
        Console.Clear();
        Console.WriteLine($"{_name}: {_description}");
        Console.WriteLine();
        Console.WriteLine($"You picked the {_name} activity. How long do you want to do it for?");
        Console.Write("Put time in seconds Ex. 10 : ");
        _time = int.Parse(Console.ReadLine());
        _mathTime = (_time * 1000);
        Console.WriteLine();

    }

    public void EndActivity() {
        Console.WriteLine();
        Console.WriteLine($"You did the {_name} activity for {_time} seconds!");
        Console.WriteLine();

    }
}