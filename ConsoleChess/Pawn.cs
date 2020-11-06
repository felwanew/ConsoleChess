using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Pawn
    {
        public bool CheckIfMoveLegalWhitePawn(int [] MoveArray, string[,] Array)
        {
            //New Position of Number = Convert.ToInt32(MoveArray[3])
            //New Position of Letter = Convert.ToInt32(MoveArray[2])
            //Old Position of Number = Convert.ToInt32(MoveArray[1])
            //Old Position of Letter = Convert.ToInt32(MoveArray[0])  
            if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) - 2 && MoveArray.GetValue(2) == MoveArray.GetValue(0) && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) =="  " )
                return true;
            else if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) - 4 && Convert.ToInt32(MoveArray.GetValue(1)) >=14 && MoveArray.GetValue(2) == MoveArray.GetValue(0) && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)) -2, Convert.ToInt32(MoveArray.GetValue(2)))) == "  " && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) == "  ")
                return true;
            else if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) - 2  && Convert.ToInt32(MoveArray.GetValue(2)) == Convert.ToInt32(MoveArray.GetValue(0)) - 2 || Convert.ToInt32(MoveArray.GetValue(2)) == Convert.ToInt32(MoveArray.GetValue(0)) + 2 && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) != "  ")
                return true;
            else
                return false;
        }
        public bool CheckIfMoveLegalBlackPawn(int[] MoveArray, string[,] Array)
        {
            //New Position of Number = Convert.ToInt32(MoveArray[3])
            //New Position of Letter = Convert.ToInt32(MoveArray[2])
            //Old Position of Number = Convert.ToInt32(MoveArray[1])
            //Old Position of Letter = Convert.ToInt32(MoveArray[0])
            if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) + 2 && (MoveArray.GetValue(2) == MoveArray.GetValue(0) && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) == "  ")
                return true;
            else if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) + 4 && Convert.ToInt32(MoveArray.GetValue(1)) <= 4 && Convert.ToInt32(MoveArray.GetValue(2)) == Convert.ToInt32(MoveArray.GetValue(0)) && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)) + 2, Convert.ToInt32(MoveArray.GetValue(2)))) == "  " && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) == "  ")
                return true;
            else if (Convert.ToInt32(MoveArray.GetValue(3)) == Convert.ToInt32(MoveArray.GetValue(1)) + 2 && Convert.ToInt32(MoveArray.GetValue(2)) == Convert.ToInt32(MoveArray.GetValue(0)) + 2 || Convert.ToInt32(MoveArray.GetValue(2)) == Convert.ToInt32(MoveArray.GetValue(0)) - 2 && Convert.ToString(Array.GetValue(Convert.ToInt32(MoveArray.GetValue(3)), Convert.ToInt32(MoveArray.GetValue(2)))) != "  ")
                return true;
            else
                return false;

        }
    }
}
