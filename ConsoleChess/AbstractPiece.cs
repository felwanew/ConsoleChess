using System;
using System.Collections.Generic;
using System.Text;
/*
 * This Class provides Methods to check if a move is legal
 * Array means the whole playfield and is required to check if a field is occupied or empty
 * The 4 Ints are the index of the old and the new position of a chess piece
 * 
 */
namespace ConsoleChess
{
    public abstract class AbstractPiece
    {
        public bool IsWhite { get; }

        protected AbstractPiece(bool isWhite)
        {
            IsWhite = isWhite;
        }

        public bool StraightMoveLegalAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (OldLetter != NewLetter && OldNumber == NewNumber || OldLetter == NewLetter && OldNumber != NewNumber)
                return true;
            return false;
        }

        public bool DiagonalMoveLegalAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (OldLetter == NewLetter + 1 && OldNumber == NewNumber + 1 ||
            OldLetter == NewLetter + 2 && OldNumber == NewNumber + 2 ||
            OldLetter == NewLetter + 3 && OldNumber == NewNumber + 3 ||
            OldLetter == NewLetter + 4 && OldNumber == NewNumber + 4 ||
            OldLetter == NewLetter + 5 && OldNumber == NewNumber + 5 ||
            OldLetter == NewLetter + 6 && OldNumber == NewNumber + 6 ||
            OldLetter == NewLetter + 7 && OldNumber == NewNumber + 7 ||
            OldLetter == NewLetter - 1 && OldNumber == NewNumber - 1 ||
            OldLetter == NewLetter - 2 && OldNumber == NewNumber - 2 ||
            OldLetter == NewLetter - 3 && OldNumber == NewNumber - 3 ||
            OldLetter == NewLetter - 4 && OldNumber == NewNumber - 4 ||
            OldLetter == NewLetter - 5 && OldNumber == NewNumber - 5 ||
            OldLetter == NewLetter - 6 && OldNumber == NewNumber - 6 ||
            OldLetter == NewLetter - 7 && OldNumber == NewNumber - 7 ||
            OldLetter == NewLetter - 1 && OldNumber == NewNumber + 1 ||
            OldLetter == NewLetter - 2 && OldNumber == NewNumber + 2 ||
            OldLetter == NewLetter - 3 && OldNumber == NewNumber + 3 ||
            OldLetter == NewLetter - 4 && OldNumber == NewNumber + 4 ||
            OldLetter == NewLetter - 5 && OldNumber == NewNumber + 5 ||
            OldLetter == NewLetter - 6 && OldNumber == NewNumber + 6 ||
            OldLetter == NewLetter - 7 && OldNumber == NewNumber + 7 ||
            OldLetter == NewLetter + 1 && OldNumber == NewNumber - 1 ||
            OldLetter == NewLetter + 2 && OldNumber == NewNumber - 2 ||
            OldLetter == NewLetter + 3 && OldNumber == NewNumber - 3 ||
            OldLetter == NewLetter + 4 && OldNumber == NewNumber - 4 ||
            OldLetter == NewLetter + 5 && OldNumber == NewNumber - 5 ||
            OldLetter == NewLetter + 6 && OldNumber == NewNumber - 6 ||
            OldLetter == NewLetter + 7 && OldNumber == NewNumber - 7)
                return true;
            return false;

        }
    }
}
