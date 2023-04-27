
public class Enemy
{
    public int healthPoints {get;set;}

    public bool IsDead
    {
        get
        {
            return (HealthPoints <= 0) ? true : false;
        }
    }
}
