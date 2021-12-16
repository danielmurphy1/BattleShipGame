using System;

namespace BattleShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            Player player = new Player();
            Ship ship = new Ship();

            //bool isBattleShipSunk = false;
            screen.WelcomeMessage();

            if (Console.ReadKey(true).KeyChar == ' ')
            {
                Console.Clear();
                screen.GenerateGameboard();
                ship.RandomShipPlacement();

            }
            else
            {
                return;
            }


            while (!ship.isBattleShipSunk)
            {

                screen.ShowShipAndPlayerStatus(player.shots, ship.battleShipLives);
                player.FireShot();
                if (player.IsShotValid(screen.gameBoard))
                {
                    player.SubtractShot();

                    //10-player.yChoice is used because the grid for the game is labled in 
                    //inverse order of the 2D array indices
                    if (ship.IsShipHit(player.xCoordValue, 10 - player.yCoordValue))
                    {
                        Console.Clear();
                        ship.BattleShipHit();
                        screen.UpdateGameBoard(player.yCoordValue, player.xCoordValue, " X ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t\t\tHit");
                        Console.ResetColor();
                    } else
                    {
                        Console.Clear();
                        screen.UpdateGameBoard(player.yCoordValue, player.xCoordValue, " O ");
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\tMiss");
                        Console.ResetColor();
                    }
                    Console.WriteLine($"Your last guess was {player.xCoordValue}, {10 - player.yCoordValue}");
                }
                else
                {
                    Console.Clear();
                    screen.GenerateGameboard();
                    Console.WriteLine($"Your last guess was {player.xCoordValue}, {10 - player.yCoordValue}");

                    Console.WriteLine("That was not a valid choice. Please only select numbers 1-10.");
                }

                if (ship.battleShipLives == 0)
                {
                    Console.WriteLine("Congratulations - You Win! You have sunk the BattleShip!");
                    ship.ToggleIsBattleShipSunk();
                }

                if (player.shots == 0)
                {
                    Console.WriteLine("You have 0 shots remaining - You Lose. You have failed to sink the BattleShip.");
                    ship.ToggleIsBattleShipSunk();
                }

                if (ship.isBattleShipSunk)
                {
                    screen.PlayAgainMessage();
                    var input = char.ToUpper(Console.ReadKey(true).KeyChar);
                    if (input.Equals('Y'))
                    {
                        Console.Clear();
                        ship.ToggleIsBattleShipSunk();
                        ship.ResetBattleShipLives();
                        ship.RandomShipPlacement();
                        screen.ResetGameBoard();
                        player.ResetShots();
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            Console.Clear();
            screen.GoodbyeMessage();
            
        }
    }
}
