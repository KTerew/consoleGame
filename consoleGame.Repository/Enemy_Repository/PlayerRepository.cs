using consoleGame.Data.Entities.Player_Entities;

public class PlayerRepository
{
    private List<Player> _playerDb = new List<Player>();

    private int _count;

    public void turn(string text)
    {
        System.Console.WriteLine(text);
    }
}
