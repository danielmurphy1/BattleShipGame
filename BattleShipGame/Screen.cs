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
                    if (gameBoard[i, j] == " O ")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else if (gameBoard[i, j] == " X ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();

                    }
                    else if (gameBoard[i, j] == " ■ ")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();


                    }
                    else
                    {
                        Console.Write(gameBoard[i, j] + " \t");

                    }

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

        public void PlayAgainMessage()
        {
            Console.WriteLine("\n\nWould you like to play again? \nPress Y to play again or any other key to exit");
        }

        public void ResetGameBoard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == " X " || gameBoard[i, j] == " O ")
                    {
                        gameBoard[i, j] = " ■ ";
                    }

                }
            }
            GenerateGameboard();
        }

        public void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tWelcome to Console BattleShip");
            Console.WriteLine("\n\n\t\t\t\t\t\tThere is one ship to find and sink. \n\t\t\tChoose the space to shoot by first entering the horizontal number (column)\n\t\t\t and then vertical number (row) of the space you would like to fire upon.\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tPress SPACEBAR to play.");
        }

        public void GoodbyeMessage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t\t\t\tThank you for playing Console BattleShip! Goodbye.");
        }
    }
}
