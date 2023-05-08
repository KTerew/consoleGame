using consoleGame.Data.Entities.Player_Entities;

public class Enemy
{
    public Enemy(Weapons weapon, string name, int hp)
    {
        enemyWeapon = weapon;
        Name = name;
        healthPoints = hp;
    }
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int healthPoints { get; set; }
    public Weapons enemyWeapon {get;set;}
    public InGameItems Sword = new InGameItems();
    public InGameItems Spear = new InGameItems();
    public InGameItems Hammer = new InGameItems();

    public void DecreaseHealth(int value)
    {
        healthPoints -= value;
    }
    public bool IsDead
    {
        get
        {
            return (healthPoints <= 0) ? true : false;
        }
    }

    private void UseEnemyWeapon(Enemy enemy,Player player, int attackPower, int accuracy, Weapons weapon)
    {
        Random rand = new Random();
        int number = rand.Next(0, 99);
        if (accuracy > number)
        {
            System.Console.WriteLine($"{enemy.Name} attacked {player.Name} with {weapon.Name}! \n"+
            $"It did {attackPower} damage, {player.Name} is at {player.healthPoints} ");
        }
    }
}
