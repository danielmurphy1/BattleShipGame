using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    internal class Screen
    {
        public string[,] gameBoard = new string[11, 11]
        {
            { "10)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 9)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 8)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 7)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 6)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 5)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 4)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 3)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 2)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 1)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " # ", " 1)", " 2)", " 3)", " 4)", " 5)", " 6)", " 7)", " 8)", " 9)", " 10)" },

        };

        public void GenerateGameboard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {   
                    Console.Write(gameBoard[i, j] + " \t");
                }

                Console.WriteLine("\n");
            }
        }

        public void UpdateGameBoard(int updateX, int updateY, string updateIcon = "■")
        {
            gameBoard[updateX, updateY] = updateIcon;
            GenerateGameboard();
        }

        public void ShowShipAndPlayerStatus(int shots, int battleShipLives)
        {
            Console.WriteLine($"\nPlayer Shots Remaining: {shots}. \n\nBattleShip Lives Remaining: {battleShipLives}.");
        }
    }
}
