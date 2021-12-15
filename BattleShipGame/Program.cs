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

            bool isBattleShipSunk = false;


            while(!isBattleShipSunk)
            {
                player.FireShot();
                if (player.IsShotValid(screen.gameBoard))
                {
                    Console.Clear();
                    screen.UpdateGameBoard(player.yChoice, player.xChoice, " X ");
                    Console.WriteLine($"Your last guess was {player.xChoice}, {10 - player.yChoice}");
                }
                else
                {
                    Console.Clear();
                    screen.GenerateGameboard();
                    Console.WriteLine($"Your last guess was {player.xChoice}, {10 - player.yChoice}");

                    Console.WriteLine("That was not a valid choice. Please only select numbers 1-10.");
                }
            }

        }
    }
}
