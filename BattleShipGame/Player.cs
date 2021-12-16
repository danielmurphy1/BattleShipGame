using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    internal class Player
    {
        public int xCoordValue;
        public int yCoordValue;
        public int shots = 10;

        public void FireShot()
        {
            Console.Write("\nEnter guess for X (horizontal) coordinate (column) 1-10: ");
            if (int.TryParse(Console.ReadLine(), out int xChoice))
            {
               xCoordValue = xChoice;
            }

            Console.Write("\nEnter guess for Y (vertical) coordinate (row) 1-10: ");
            if (int.TryParse(Console.ReadLine(), out int yChoice))
            {
               yCoordValue = 10 - yChoice;
            }
        }

        public void SubtractShot()
        {
            shots--;
        }

        public bool IsShotValid(string[,] gameBoard)
        {
            return xCoordValue >= 1 && xCoordValue <= 10 && yCoordValue >= 0 && yCoordValue <= 9 && gameBoard[yCoordValue, xCoordValue] == " ■ ";
        }

        public void ResetShots()
        {
            shots = 10;
        }
       
    }
}
