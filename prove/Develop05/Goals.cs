public class Goal
{
    protected int g_points = 0;
    protected string g_name = "";
    protected bool g_status = false;
    protected string g_type = "S";


    public Goal() 
    {
    }
    public virtual void create_goal(string type, int points, string name)
    {
        
        g_points = points;
        g_name = name;
        g_type = type;
    }

    public virtual void Complete_goal(User user)
    {
        g_status = true;
        user.gain_points(g_points);
    }
}