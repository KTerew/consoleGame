
public class Player
{
    public Player(string name)
    {
        Name = name;
    }

    public int ID {get;set;}
    public string Name {get;set;}= string.Empty;
    public int healthPoints {get; set;} = 100;

    public List<Items> Bag;
    
    
    public void DecreaseHealth(int value)
    {
        healthPoints -= value;
    }
    public void IncreaseHealth(int value)
    {
        healthPoints += value;
    }
    public bool IsDead
    {
        get
        {
            return (healthPoints <= 0) ? true : false;
        }
    }

    private void UseWeapon(Enemy enemy, int attackPower, int accuracy)
    {
        Random rand = new Random();
        int number = rand.Next(0,99);
        if(accuracy > number)
        {

            System.Console.WriteLine();
        }
    }
}
