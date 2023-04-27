
public class Player
{
    public string Name = string.Empty();

    public int healthPoints {get; set;} = 100;
    public List<Items> Bag;
    
    public bool IsDead
    {
        get
        {
            return (healthPoints <= 0) ? true : false;
        }
    }


}
