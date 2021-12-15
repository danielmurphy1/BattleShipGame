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
                Console.Write("Enter guess for X (horizontal) coordinate (column) 1-10: ");
                if (int.TryParse(Console.ReadLine(), out int xCoordValue))
                {
                    player.xChoice = xCoordValue;
                }

                Console.Write("Enter guess for Y (vertical) coordinate (row) 1-10: ");
                if (int.TryParse(Console.ReadLine(), out int yCoordValue))
                {
                    player.yChoice = 10 - yCoordValue;
                }
                Console.WriteLine($"Your guess was {player.xChoice}, {10 - player.yChoice}");
                screen.UpdateGameBoard(player.yChoice, player.xChoice, " X");
            }

        }
    }
}
