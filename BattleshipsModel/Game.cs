using System;
using System.Collections.Generic;

namespace BattleshipsModel
{
    class Game
    {
        static void Main(string[] args)
        {
            Board board = new Board(10);
            Player player1 = new Player("Andrei", 1);
            Player player2 = new Player("John", 1);
            PlayerBoard board1 = new PlayerBoard(10);
            try
            {
                SquareLocation squareLocation = new SquareLocation(5, 5, board);
                //Console.WriteLine(board.OnBoard(squareLocation));
                board.PrintBoard();
                player1.MarkSquare(2, 3);
                Console.WriteLine("Player 1 Board:");
                player1.Board.PrintBoard();

                //List<SquareLocation> list = new List<SquareLocation>();
                //list.Add(squareLocation);
                //for (int i = 0; i < board._sideLength; i++)
                //{
                //    for (int j = 0; j < board._sideLength; j++)
                //    {
                //        if (list.Exists(squareloc => squareloc.X == i && squareloc.Y == j))
                //        {
                //            Console.WriteLine("IT CONTAINS IT");
                //        }
                //    }
                //}
                
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