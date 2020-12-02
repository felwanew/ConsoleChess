﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Tower : AbstractMovement
    {
        public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (StraightMoveLegalAbstract(Array, OldLetter, OldNumber, NewLetter, NewNumber))
                return true;
            return false;        
        }
    }
}
