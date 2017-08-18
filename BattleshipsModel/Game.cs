using System;

namespace BattleshipsModel
{
    class Game
    {
        static void Main(string[] args)
        {
            Board board = new Board(10);
            try
            {
                SquareLocation squareLocation = new SquareLocation(5, 20, board);
                //Console.WriteLine(board.OnBoard(squareLocation));
            }
            catch(NotOnBoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(BattleshipException)
            {
                Console.WriteLine("Unhandled BattleshipException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}