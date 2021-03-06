﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class King : AbstractMovement
    {
        public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            if (KingMoveLegalAbstract(Array, OldLetter, OldNumber, NewLetter, NewNumber))
                return true;
            return false;
        }
    }
}
