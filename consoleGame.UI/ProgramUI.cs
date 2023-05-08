using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleGame.Data.Entities.Player_Entities;

namespace consoleGame.UI
{
    public class ProgramUI
{
    private bool isRunning = true;
    private PlayerRepository _playerRepo = new PlayerRepository();
    public ProgramUI(){}

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        Clear();
        WriteLine("What is your name?");
        string name = ReadLine();
        Player user = new Player(name);

        while (isRunning)
        {
            
            Clear();
            WriteLine("Welcome to Fight club, Please make a selection: \n" +
            "1. Start Game\n"+
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
        WriteLine("Thanks for Playing");
        PressAnyKeyToContinue();
        Clear();
        return false;
    }

    private void StartGame()
    {
        System.Console.WriteLine("You awake in the woods unsure of where you are...\n" +
                                "You start walking in your best attempt at a straightline to not get lost until you come across a break in the trees\n" +
                                "In the middle of the clearing you see a pond glistening in the sun\n" +
                                "1. Approach the pond\n" +
                                "2. Continue along the forest");
    }
    private void StartFight(Enemy enemy, Weapons weapon)
    {

        _playerRepo.turn($"You encounter an {enemy.Name} weilding a {weapon.Name}...\n"+
                                "What do you wish to do?\n"+
                                "1. Fight\n" +
                                "2. Items\n"+
                                "3. Quit to Menu");
    }

    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }
}

}