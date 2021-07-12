using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class King : AbstractPiece, IChessPiece
    {
        public King(bool isWhite)
            : base(isWhite)
        {
        }

        public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (OldLetter == NewLetter && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber)
                return true;
            return false;
        }
    }
}
