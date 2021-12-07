using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Knight : AbstractPiece, IChessPiece
    {
        public Knight(bool isWhite)
            : base(isWhite)
        {
        }

        public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (OldLetter == NewLetter + 1 && OldNumber == NewNumber + 2 ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber - 2 ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber + 2 ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber - 2 ||
                OldLetter == NewLetter + 2 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter + 2 && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter - 2 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter - 2 && OldNumber == NewNumber - 1)
                return true;
            return false;
        }
    }
}
