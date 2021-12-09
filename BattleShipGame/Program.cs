using System;

namespace BattleShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.GenerateGameboard();
        }
    }
}
