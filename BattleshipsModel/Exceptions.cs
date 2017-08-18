using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipsModel
{
    class BattleshipException : Exception
    {
        public BattleshipException() { }
        public BattleshipException(string message) : base(message) { }
    }

    class NotOnBoardException : BattleshipException
    {
        public NotOnBoardException() { }
        public NotOnBoardException(string message) : base(message) { }
    }
}
