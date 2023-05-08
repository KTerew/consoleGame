using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleGame.Data.Entities.Player_Entities;


public class ProgramUI
{
    private bool isRunning = true;
    private PlayerRepository _playerRepo = new PlayerRepository();
    public ProgramUI() { }

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        Console.Clear();
        WriteLine("What is your name?");
        string name = ReadLine();
        Player user = new Player(name);

        while (isRunning)
        {

            Console.Clear();
            WriteLine("Welcome to Fight club, Please make a selection: \n" +
            "1. Start Game\n" +
            "2. End Game\n");

            var userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    isRunning = CloseGame();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
    }

    private bool CloseGame()
    {
        Console.Clear();
        WriteLine("Thanks for Playing");
        PressAnyKeyToContinue();
        Console.Clear();
        return false;
    }

    private void StartGame()
    {
        Console.Clear();
        isRunning = true;
        while (isRunning)
        {
            WriteLine("You awake in the woods unsure of where you are...\n" +
                    "You start walking in your best attempt at a straightline to not get lost until you come across a break in the trees\n" +
                    "In the middle of the clearing you see a pond glistening in the sun\n" +
                    "1. Approach the pond\n" +
                    "2. Continue along the forest");
            var userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                    Weapons sword = new Weapons
                    {
                        ID = 10,
                        Name = "Rusted Sword",
                        Description = "A one handed blade. A little rusted...",
                        AttackPower = 5,
                        Accuracy = 80
                    };
                    Enemy octopus = new Enemy(sword, "Octopus Pirate", 80);
                    Console.Clear();
                    WriteLine("You slowly creep up to the pond still cautious of your surroundings... You can't shake this feeling you are beeing watched\n" +
                                "Just as you reach the foot of the pond a tentacle pops out of the water and lashes at you!");
                    PressAnyKeyToContinue();
                    StartFight(octopus, sword);
                    isRunning = CloseGame();
                    break;
                case "2":
                    Console.Clear();
                    WriteLine("You continue along the forest and find your way out through hard work and perseverance!");
                    WriteLine("Thank you for playing!");
                    PressAnyKeyToContinue();
                    isRunning = CloseGame();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
    }
    private void StartFight(Enemy enemy, Weapons weapon)
    {
        isRunning = true;
        while (isRunning)
        {
            _playerRepo.turn($"You encounter an {enemy.Name} weilding a {weapon.Name}...\n" +
                                    "What do you wish to do?\n" +
                                    "1. Fight\n" +
                                    "2. Items\n" +
                                    "3. Surrender");
            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    isRunning = FightMenu();
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    isRunning = ItemsMenu();
                    break;
                case "3":
                    isRunning = Surrender(enemy);
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
    }

    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }

    private bool FightMenu()
    {
        WriteLine("Fighting Screen");
        return false;
    }

    private bool ItemsMenu()
    {
        return false;
    }

    private bool Surrender(Enemy enemy)
    {
        WriteLine("I see you have chosen defeat... A pity really thought you would of been fun");
        Clear();
        WriteLine($"The {enemy.Name} chops off your head you are dead...");
        PressAnyKeyToContinue();
        return false;
    }

    private void GameOver()
    {
        WriteLine("As you reach for your item bag you're struck down in an instant\n" +
                    "Game Over!");
    }
}

