public class Checklist : Goal
{
    int _RequiredCount;
    int _Reward;
    int count = 0;
    public Checklist()
    {

    }

    public override void create_goal(string type, int points, int reward,int requirement, string name) : base( type,  points,  name)
    {
        g_name = name;
        g_points = points;
        _RequiredCount = requirement;
        _Reward = reward;
    }
    public override void Complete_goal(User user)
    {
        if (count == _RequiredCount)
        {
            Console.WriteLine($"Congratulations you've completed that goal {count}/{_RequiredCount}! We'll mark this one complete");
            user.gain_points(g_points);
            user.gain_points(_Reward);
        }
        else{
            count += count;
            Console.WriteLine($"Congratulations, you've completed that goal {count} times! You only have {_RequiredCount - count} left!");
            user.gain_points(g_points);
        }
        
        
    }
}