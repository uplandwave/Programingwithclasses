public class User
{
    private int score = 0;



    public User()
    {}

    public void gain_points(int points)
    {
        score += points;
    }
    public int get_score()
    {
        return score;
    }
}