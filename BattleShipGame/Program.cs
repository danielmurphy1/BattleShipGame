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

            bool isBattleShipSunk = false;

            ship.RandomShipPlacement();

            while(!isBattleShipSunk)
            {
                player.FireShot();
                if (player.IsShotValid(screen.gameBoard))
                {
                    //Console.Clear();
                    screen.UpdateGameBoard(player.yCoordValue, player.xCoordValue, " X ");
                    //10-player.yChoice is used because the grid for the game is labled in 
                    //inverse order of the 2D array indices
                    if (ship.IsShipHit(player.xCoordValue, 10 - player.yCoordValue))
                    {
                        Console.WriteLine("Hit");
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
            }

        }
    }
}
