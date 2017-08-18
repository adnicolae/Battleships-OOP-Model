using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipsModel
{
    class Player
    {
        public PlayerBoard Board { get; set; } = new PlayerBoard(10);
        public int ShipsRemaining { get; set; }
        private string _name;

        public Player(string name, int numberOfShips)
        {
            _name = name;
            ShipsRemaining = numberOfShips;
        }

        public void MarkSquare(int x, int y)
        {
            Board.MarkedLocations.Add(new SquareLocation(x, y, Board));
        }
    }
}
