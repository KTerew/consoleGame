using consoleGame.Data.Entities.Player_Entities;

public class Player
{
    public Player(string name)
    {
        Name = name;
        SetupPlayerInitialization();
    }

    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int healthPoints { get; set; } = 100;

    public List<InGameItems> Items = new List<InGameItems>();
    public InGameItems Sword = new InGameItems();
    public InGameItems Spear = new InGameItems();
    public InGameItems Hammer = new InGameItems();

    public InGameItems Potion = new InGameItems();
    public InGameItems Shield =new InGameItems();
    public InGameItems Javelin = new InGameItems();



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
        int number = rand.Next(0, 99);
        if (accuracy > number)
        {

            System.Console.WriteLine();
        }
    }

    // public void PlayerWeaponChoice()
    // {
    //     System.Console.WriteLine("Choose your weapon!\n" +
    //     $"1. {Sword.Name}. {Sword.Description}\n" +
    //     $"2. {Spear.Name}. {Spear.Description}\n" +
    //     $"3. {Hammer.Name}. {Hammer.Description}\n"
    //     );

    //     var userInput = System.Console.ReadLine();
    //     switch (userInput)
    //     {
    //         case "1":
    //         System.Console.WriteLine("You have chosen the Sword!");
    //         Bag.Add(Sword);
    //         break;
    //         case "2":
    //         System.Console.WriteLine("You have chosen the Spear!");
    //         Bag.Add(Spear);
    //         break;
    //         case "3":
    //         System.Console.WriteLine("You have chosen the Hammer");
    //         Bag.Add(Hammer);
    //         break;
    //         default:
    //         System.Console.WriteLine("That is not a valid input");
    //         break;
    //     }
    // }
    public void SetupPlayerInitialization()
    {
        // Items = GameUtilities.InitializePlayerStartupItems();
        // Sword = Items[0];
        // Spear = Items[1];
        // Hammer = Items[2];

        Items = new List<InGameItems>
        {
            new Weapons
            {
                ID = 1,
                Name = "Rusted Sword",
                Description = "A one handed blade. A little rusted...",
                AttackPower = 15,
                Accuracy = 80
            },
            new Weapons
            {
                ID = 2,
                Name = "Shabby Spear",
                Description = "A two handed spear. Barely held together by rope...",
                AttackPower = 10,
                Accuracy = 95
            },
            new Weapons
            {
                ID = 3,
                Name = "Dented Hammer",
                Description = "A two handed warhammer. Its covered in dents...",
                AttackPower = 25,
                Accuracy = 65
            },
            new Items
            {
                ID = 4,
                Name = "Potion",
                Description = "Heals player for 30 HP.",
                beenUsed = false
            },
            new Items
            {
                ID = 5,
                Name = "Shield",
                Description = "Lowers Enemy's accuracy by 50% until hit.",
                beenUsed = false
            },
            new Items
            {
                ID = 6,
                Name = "Javelin",
                Description = "Damages Enemy and stuns for 1 turn.",
                beenUsed = false
            }
        };

        Sword = Items[0];
        Spear = Items[1];
        Hammer = Items[2];
        Potion = Items[3];
        Shield = Items[4];
        Javelin = Items[5];
    }
}
