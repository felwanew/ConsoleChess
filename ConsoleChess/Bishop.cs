using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Bishop
    {
        public bool CheckIfMoveIsLegal(int [] MoveArray){
            //New Position of Number = Convert.ToInt32(MoveArray[3])
            //New Position of Letter = Convert.ToInt32(MoveArray[2])
            //Old Position of Number = Convert.ToInt32(MoveArray[1])
            //Old Position of Letter = Convert.ToInt32(MoveArray[0])  
            if (Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 2 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 2 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 4 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 4 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 6 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 6 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 8 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 8 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 10 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 10 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 12 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 12 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 14 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 14 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 16 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 16 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 2 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 2 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 4 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 4 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 6 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 6 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 8 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 8 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 10 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 10 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 12 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 12 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 14 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 14 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 16 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 16 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 2 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 2 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 4 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 4 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 6 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 6 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 8 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 8 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 10 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 10 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 12 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 12 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 14 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 14 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) - 16 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) + 1 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 2 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 2 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 4 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 4 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 6 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 6 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 8 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 8 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 10 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 10 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 12 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 12 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 14 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 14 ||
                    Convert.ToInt32(MoveArray.GetValue(0)) == Convert.ToInt32(MoveArray.GetValue(2)) + 16 && Convert.ToInt32(MoveArray.GetValue(1)) == Convert.ToInt32(MoveArray.GetValue(3)) - 16)
                return true;
            return false;

            }
    }
}
