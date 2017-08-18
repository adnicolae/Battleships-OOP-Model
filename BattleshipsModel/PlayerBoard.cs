using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipsModel
{
    class PlayerBoard : Board
    {
        //public ICollection<SquareLocation> MarkedLocations { get; set; }
        public List<SquareLocation> MarkedLocations { get; set; } = new List<SquareLocation>();
        public PlayerBoard(int sideLength) : base(sideLength) { }

        //public void MarkSquare(int x, int y)
        //{
        //    MarkedLocations.Add(new SquareLocation(x, y, this));
        //}

        public override void PrintBoard()
        {
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength; j++)
                {
                    //if (MarkedLocations.Contains(new SquareLocation(i,j, this)))
                    if (MarkedLocations.Exists(location => location.X == i && location.Y == j))
                    {
                        Console.Write("S ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
