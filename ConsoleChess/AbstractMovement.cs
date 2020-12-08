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
        public bool KingMoveLegalAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber) //the proving of the case "the king is in a Schach with a move" is missing 
        {
            if(OldLetter == NewLetter && OldNumber == NewNumber + 1 ||
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
        public bool KnightMoveLegalAbstract(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber) 
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
