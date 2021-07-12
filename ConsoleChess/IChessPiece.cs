using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public interface IChessPiece
    {
        bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber);
        bool IsWhite { get; }
    }
}
