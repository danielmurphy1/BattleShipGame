using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    internal class Ship
    {
        int[] shipFirstPosition = new int[2];
        int[] shipSecondPosition = new int[2];
        int[] shipThirdPosition = new int[2];
        int[] shipFourthPosition = new int[2];
        int[] shipFifthPosition = new int[2];
        public int battleShipLives = 5;
        public bool isBattleShipSunk = false;

        Random random = new Random();

        public void RandomShipPlacement()
        {
            shipFirstPosition[0] = random.Next(1, 11);
            shipFirstPosition[1] = random.Next(1, 11);
            //Console.WriteLine($"shipFirstPosition: {shipFirstPosition[0]}, {shipFirstPosition[1]}");

            if (DetermineShipDirection() == "Horizontal")
            {
                
                if (shipFirstPosition[0] > 6)
                {
                    shipSecondPosition[0] = shipFirstPosition[0] - 1;
                    shipSecondPosition[1] = shipFirstPosition[1];
                    shipThirdPosition[0] = shipFirstPosition[0] - 2;
                    shipThirdPosition[1] = shipFirstPosition[1];
                    shipFourthPosition[0] = shipFirstPosition[0] - 3;
                    shipFourthPosition[1] = shipFirstPosition[1];
                    shipFifthPosition[0] = shipFirstPosition[0] - 4;
                    shipFifthPosition[1] = shipFirstPosition[1];
                } else
                {
                    shipSecondPosition[0] = shipFirstPosition[0] + 1;
                    shipSecondPosition[1] = shipFirstPosition[1];
                    shipThirdPosition[0] = shipFirstPosition[0] + 2;
                    shipThirdPosition[1] = shipFirstPosition[1];
                    shipFourthPosition[0] = shipFirstPosition[0] + 3;
                    shipFourthPosition[1] = shipFirstPosition[1];
                    shipFifthPosition[0] = shipFirstPosition[0] + 4;
                    shipFifthPosition[1] = shipFirstPosition[1];
                }
                //Console.WriteLine($"shipSecondPosition: {shipSecondPosition[0]}, {shipSecondPosition[1]}");
                //Console.WriteLine($"shipThirdPosition: {shipThirdPosition[0]}, {shipThirdPosition[1]}");
                //Console.WriteLine($"shipFourthPosition: {shipFourthPosition[0]}, {shipFourthPosition[1]}");
                //Console.WriteLine($"shipFifthPosition: {shipFifthPosition[0]}, {shipFifthPosition[1]}");

            } else
            {
                if (shipFirstPosition[1] > 6)
                {
                    shipSecondPosition[0] = shipFirstPosition[0];
                    shipSecondPosition[1] = shipFirstPosition[1] - 1;
                    shipThirdPosition[0] = shipFirstPosition[0];
                    shipThirdPosition[1] = shipFirstPosition[1] - 2;
                    shipFourthPosition[0] = shipFirstPosition[0];
                    shipFourthPosition[1] = shipFirstPosition[1] - 3;
                    shipFifthPosition[0] = shipFirstPosition[0];
                    shipFifthPosition[1] = shipFirstPosition[1] - 4;
                }
                else
                {
                    shipSecondPosition[0] = shipFirstPosition[0];
                    shipSecondPosition[1] = shipFirstPosition[1] + 1;
                    shipThirdPosition[0] = shipFirstPosition[0];
                    shipThirdPosition[1] = shipFirstPosition[1] + 2;
                    shipFourthPosition[0] = shipFirstPosition[0];
                    shipFourthPosition[1] = shipFirstPosition[1] + 3;
                    shipFifthPosition[0] = shipFirstPosition[0];
                    shipFifthPosition[1] = shipFirstPosition[1] + 4;
                }
                //Console.WriteLine($"shipSecondPosition: {shipSecondPosition[0]}, {shipSecondPosition[1]}");
                //Console.WriteLine($"shipThirdPosition: {shipThirdPosition[0]}, {shipThirdPosition[1]}");
                //Console.WriteLine($"shipFourthPosition: {shipFourthPosition[0]}, {shipFourthPosition[1]}");
                //Console.WriteLine($"shipFifthPosition: {shipFifthPosition[0]}, {shipFifthPosition[1]}");
            }
        }

        public string? DetermineShipDirection()
        {
            int shipDirectionRandom = random.Next(2);
            //int shipDirectionRandom = 1;

            switch (shipDirectionRandom)
            {
                case 0:
                    return "Horizontal";
                case 1:
                    return "Vertical";
            }
            return null;
        }

        public bool IsShipHit(int xChoice, int yChoice)
        {
            return (xChoice == shipFirstPosition[0] ||
                    xChoice == shipSecondPosition[0] ||
                    xChoice == shipThirdPosition[0] ||
                    xChoice == shipFourthPosition[0] ||
                    xChoice == shipFifthPosition[0]) &&
                    (yChoice == shipFirstPosition[1] ||
                    yChoice == shipSecondPosition[1] ||
                    yChoice == shipThirdPosition[1] ||
                    yChoice == shipFourthPosition[1] ||
                    yChoice == shipFifthPosition[1]);
        }

        public void BattleShipHit()
        {
            battleShipLives--;
        }

        public bool ToggleIsBattleShipSunk()
        {
            return isBattleShipSunk = !isBattleShipSunk;
        }

        public void ResetBattleShipLives()
        {
            battleShipLives = 5;
        }
    }
}
