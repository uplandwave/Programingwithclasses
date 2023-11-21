public class Eternal : Goal
{
    int streak = 0;
    int high =0;


    public Eternal()
    {

    }

    public override void Complete_goal(User user)
    {
        user.gain_points(g_points);
        streak += streak;
        if (streak >= high)
        {
            Console.WriteLine($"Congratulations! You're currently on a streak of: {streak}. This is your new record!");
            high = streak;
        }
        else{
            Console.WriteLine($"Congratulations! You're currently on a streak of: {streak}. Keep it up, your record is: {high}!");
        }
    }
}