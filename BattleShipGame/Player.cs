using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    internal class Player
    {
        public int xChoice;
        public int yChoice;

        public void FireShot()
        {
            Console.Write("Enter guess for X (horizontal) coordinate (column) 1-10: ");
            if (int.TryParse(Console.ReadLine(), out int xCoordValue))
            {
               xChoice = xCoordValue;
            }

            Console.Write("Enter guess for Y (vertical) coordinate (row) 1-10: ");
            if (int.TryParse(Console.ReadLine(), out int yCoordValue))
            {
               yChoice = 10 - yCoordValue;
            }
            //Console.WriteLine($"Your guess was {xChoice}, {10 - yChoice}");
            //screen.UpdateGameBoard(player.yChoice, player.xChoice, " X");
        }

        public bool IsShotValid(string[,] gameBoard)
        {
            return xChoice >= 1 && xChoice <= 10 && yChoice >= 0 && yChoice <= 9 && gameBoard[yChoice, xChoice] == " ■ ";
        }
       
    }
}
