
public class Player
{
    public Player(string name)
    {
        Name = name;
    }

    public int ID {get;set;}
    public string Name {get;set;}= string.Empty;
    public int healthPoints {get; set;} = 100;

    public List<InGameItems> Items;
    private InGameItems Sword;
    private InGameItems Spear;
    private InGameItems Hammer;
    private Inventory Bag;

    
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

    public void PlayerWeaponChoice()
    {
        System.Console.WriteLine("Choose your weapon!\n" +
        $"1. {Sword.Name}. {Sword.Description}\n" +
        $"2. {Spear.Name}. {Spear.Description}\n" +
        $"3. {Hammer.Name}. {Hammer.Description}\n"
        );

        var userInput = System.Console.ReadLine();
        switch (userInput)
        {
            case "1":
            System.Console.WriteLine("You have chosen the Sword!");
            Bag.Add(Sword);
            case "2":
            System.Console.WriteLine("You have chosen the Spear!");
            Bag.Add(Spear);
            case "3":
            System.Console.WriteLine("You have chosen the Hammer");
            Bag.Add(Hammer);
            default:
            System.Console.WriteLine("That is not a valid input");
            break;
        }
    }
    public void SetupPlayerInitialization()
    {
        Items = GameUtilities.InitializePlayerStartupItems();
        Sword = Items[0];
        Spear = Items[1];
        Hammer = Items[2];

    }
}
