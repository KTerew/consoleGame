
public static class GameUtilities
{
    public static List<InGameItems> InitializePlayerStartupItems()
    {
        var textListOfWeapons = File.ReadAllLines(
            @"C:\ElevenFiftyProjects\codingFoundations\dotnetProjects\consoleGame\consoleGame.Data\Entities\Player_Entities\Weapons.txt");

        var textListOfItems = File.ReadAllLines(
            @"C:\ElevenFiftyProjects\codingFoundations\dotnetProjects\consoleGame\consoleGame.Data\Entities\Player_Entities\Items.txt");
        List<InGameItems> playerStartingChoice = new List<InGameItems>();

        for (int i = 0; i < textListOfWeapons.Length; i++)
        {
            if (textListOfWeapons[i] == "|")
            {
                var inGameWeapon = new Weapons
                {
                    ID = int.Parse(textListOfWeapons[++i],
                    Name = textListOfWeapons[++i],
                    Description = textListOfWeapons[++i],
                    AttackPower = textListOfWeapons[++i],
                    Accuracy = textListOfWeapons[++i])
                };
                playerStartingChoice.Add(inGameWeapon);
            }
        }

        for (int i = 0; i < textListOfItems.Length; i++)
        {
            if (textListOfItems == "|")
            {
                var inGameItems = new Items
                {
                    ID = int.Parse(textListOfItems[++i],
                    Name = textListOfItems[++i],
                    Description = textListOfItems[++i],
                    beenUsed[++i]
                )
                };
            }

        }
        return playerStartingChoice;
    }
}
