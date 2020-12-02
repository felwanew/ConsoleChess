using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Pawn : AbstractMovement
    {
        public bool CheckIfMoveLegalWhitePawn(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            return CheckIfMoveLegalWhitePawnAbstract(Array, OldLetter, OldNumber, NewLetter, NewNumber);
        }
        public bool CheckIfMoveLegalBlackPawn(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            return CheckIfMoveLegalBlackPawnAbstract(Array, OldLetter, OldNumber, NewLetter, NewNumber);
        }
    }
}
