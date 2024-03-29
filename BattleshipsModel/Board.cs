﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipsModel
{
    class Board
    {
        public readonly int _sideLength;

        public Board(int sideLength)
        {
            _sideLength = sideLength;
        }

        public bool OnBoard(Square square)
        {
            return square.X >= 0 && square.X < _sideLength && square.Y >= 0 && square.Y < _sideLength;
        }

        public virtual void PrintBoard()
        {
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
        }
    }
}
