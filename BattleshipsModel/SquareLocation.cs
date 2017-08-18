using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipsModel
{
    class SquareLocation : Square
    {
        public SquareLocation(int x, int y, Board board) : base(x, y)
        {
            if (!board.OnBoard(this))
            {
                throw new NotOnBoardException(this + " is not within the board's boundaries.");
            }
        }
    }
}
