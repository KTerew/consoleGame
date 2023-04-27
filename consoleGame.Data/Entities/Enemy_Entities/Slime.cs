
public class Slime
{
    public int healthPoints = 10;

    public bool IsDead
    {
        get
        {
            return (HealthPoints <= 0) ? true : false;
        }
    }
}
