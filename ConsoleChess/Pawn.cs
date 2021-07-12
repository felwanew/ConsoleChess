using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Pawn : AbstractPiece, IChessPiece
    {
        public Pawn(bool isWhite)
            : base(isWhite)
        {
        }

        public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            return IsWhite ? CheckIfMoveIsLegalWhite(Array, OldLetter, OldNumber, NewLetter, NewNumber) : CheckIfMoveIsLegalBlack(Array, OldLetter, OldNumber, NewLetter, NewNumber);
        }

        private bool CheckIfMoveIsLegalWhite(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (NewNumber == OldNumber - 1 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber - 2 && OldNumber >= 6 && NewLetter == OldLetter && Array[NewNumber + 1, NewLetter] == "  " && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber - 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else
                return false;
        }
        private bool CheckIfMoveIsLegalBlack(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (NewNumber == OldNumber + 1 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber + 2 && OldNumber <= 2 && NewLetter == OldLetter && Array[NewNumber - 1, NewLetter] == "  " && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber + 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else
                return false;
        }
    }
}
