using System;

namespace BattleShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.GenerateGameboard();
            Player player = new Player();
            Ship ship = new Ship();

            //bool isBattleShipSunk = false;

            ship.RandomShipPlacement();

            while(!ship.isBattleShipSunk)
            {

                screen.ShowShipAndPlayerStatus(player.shots, ship.battleShipLives);
                player.FireShot();
                if (player.IsShotValid(screen.gameBoard))
                {
                    //10-player.yChoice is used because the grid for the game is labled in 
                    //inverse order of the 2D array indices
                    if (ship.IsShipHit(player.xCoordValue, 10 - player.yCoordValue))
                    {
                        Console.Clear();
                        ship.BattleShipHit();
                        screen.UpdateGameBoard(player.yCoordValue, player.xCoordValue, " X ");
                        Console.WriteLine("Hit");
                    } else
                    {
                        Console.Clear();
                        screen.UpdateGameBoard(player.yCoordValue, player.xCoordValue, " O ");
                        Console.WriteLine("Miss");
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
                    //add a game winning message with color
                    Console.WriteLine("Congratulations - You Win! You have sunk the BattleShip!");
                    ship.ToggleIsBattleShipSunk();
                }

                if (player.shots == 0)
                {
                    //add game losing message with color
                    Console.WriteLine("You have 0 shots remaining - You Lose. You have failed to sink the BattleShip.");
                    ship.ToggleIsBattleShipSunk();
                }
            }
            //add play again message/functionality
                //if play again reset all 
                //if not clear console and display ending message
            
        }
    }
}
