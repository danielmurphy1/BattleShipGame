﻿using System;
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
            { " # ", " 1)", " 2)", " 3)", " 4)", " 5)", " 6)", " 7)", " 8)", " 9)", " 10)" },
            { " 1)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 2)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 3)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 4)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 5)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 6)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 7)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 8)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { " 9)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
            { "10)", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ ", " ■ " },
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
    }
}