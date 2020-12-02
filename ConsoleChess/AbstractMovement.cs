using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public abstract class AbstractMovement
    {
        public bool CheckIfMoveLegalWhitePawnAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (NewNumber == OldNumber - 1 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber - 2 && OldNumber >= 6 && NewLetter == OldLetter && Array[NewNumber +1, NewLetter] == "  " && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber - 1 && NewLetter == OldLetter -1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else
                return false;
        }
        public bool CheckIfMoveLegalBlackPawnAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (NewNumber == OldNumber + 1 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber + 2 && OldNumber <= 2 &&  NewLetter == OldLetter && Array[NewNumber - 1, NewLetter] == "  " && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (NewNumber == OldNumber + 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else
                return false;

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
        //public bool ForwardMoveLegalAbstract
    }
}
