using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleChess
{
    class Playfield
    {
        public string[,] PlayfieldArray = new string[8, 8]
        {
            { "ST", "SL", "SS", "SD", "SK", "SS", "SL", "ST"},
            { "SB", "SB", "SB", "SB", "SB", "SB", "SB", "SB"},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "WB", "WB", "WB", "WB", "WB", "WB", "WB", "WB"},
            { "WT", "WL", "WS", "WD", "WK", "WS", "WL", "WT"}
        };
        public void CreatePlayfield()
        {
            var number = 8; //number  to write down the row of a chesstile e.g. F4
            Console.WriteLine(" " + "+" + "A " + "+" + "B " + "+" + "C " + "+" + "D " + "+" + "E " + "+" + "F " + "+" + "G " + "+" + "H " + "+" + " ");  //each single string represents one column --> better overview
            Console.WriteLine(" " + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + " "); //
            for (int i = 0; i < 8; i++)    
            {
                Console.Write(number - i + "|");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(PlayfieldArray[i, j] + "|");
                }
                Console.WriteLine(number - i);
                Console.WriteLine(" " + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + " ");
            }
            Console.WriteLine(" " + "+" + "A " + "+" + "B " + "+" + "C " + "+" + "D " + "+" + "E " + "+" + "F " + "+" + "G " + "+" + "H " + "+" + " ");
        }
        public string[,] ChangePlayfield(string[,] PlayfieldArray, string[] MoveArray)
        {
            LocalizeInputInPlayfield(MoveArray);
            int OldLetter = 
            int OldNumber, NewLetter, NewNumber = 0;
            IntMoveArray = ConvertMoveArrayToInt(MoveArray, IntMoveArray);
            bool moveLegal = CheckIfMoveIsLegal(PlayfieldArray, IntMoveArray);
            if (moveLegal == true)
            {
                 DoMove(PlayfieldArray, MoveArray);
            }
            else
            {
                Console.WriteLine("Zug ungültig");
            }
            //Console.WriteLine(MoveArray[0] + " " + MoveArray[1] + " " + MoveArray[2] + " " + MoveArray[3]);

            return PlayfieldArray;
        }
        public string[] LocalizeInputInPlayfield(string[] MoveArray)
        {
            int x = 0,  index = 0;
            x = CompareLetter(x, MoveArray, index);
            MoveArray[0] = Convert.ToString(x);
            index = 1;
            x = CompareNumber(x, MoveArray, index);
            MoveArray[1] = Convert.ToString(x);
            index = 2;
            x = CompareLetter(x, MoveArray, index);
            MoveArray[2] = Convert.ToString(x);
            index = 3;
            x = CompareNumber(x, MoveArray, index);
            MoveArray[3] = Convert.ToString(x);
            return MoveArray;
        }
        private int[] ConvertMoveArrayToInt(string[] MoveArray, int[] IntMoveArray)
        {
            for(int i = 0;i < 4; i++)
            {
                IntMoveArray[i] = Convert.ToInt32(MoveArray[i]);
            }
            return IntMoveArray;
        }
        private int CompareLetter(int x, string[] MoveArray, int index)
        {
            switch (MoveArray[index])
            {
                case "A":
                    x = 0;
                    break;
                case "B":
                    x = 1;
                    break;
                case "C":
                    x = 2;
                    break;
                case "D":
                    x = 3;
                    break;
                case "E":
                    x = 4;
                    break;
                case "F":
                    x = 5;
                    break;
                case "G":
                    x = 6;
                    break;
                case "H":
                    x = 7;
                    break;
                default:
                    x = -1; //error if -1
                    break;
            }
            return x;
        }
        private int CompareNumber(int x, string[] MoveArray, int index)
        {
        switch (MoveArray[index])
            {
            case "1":
                x = 7;
                break;
            case "2":
                x = 6;
                break;
            case "3":
                x = 5;
                break;
            case "4":
                x = 4;
                break;
            case "5":
                x = 3;
                break;
            case "6":
                x = 2;
                break;
            case "7":
                x = 1;
                break;
            case "8":
                x = 0;
                break;
            default:
                x = -1; //error if -1
                break;
            }
        return x;
        }
        public  string [,] DoMove(string[,] PlayfieldArray, string[] MoveArray)
        {
            PlayfieldArray[Convert.ToInt32(MoveArray[3]), Convert.ToInt32(MoveArray[2])] = PlayfieldArray[Convert.ToInt32(MoveArray[1]), Convert.ToInt32(MoveArray[0])];
            PlayfieldArray[Convert.ToInt32(MoveArray[1]), Convert.ToInt32(MoveArray[0])] = "  ";
            return PlayfieldArray;
        }
        public bool CheckIfMoveIsLegal(string[,] Array, int[] MoveArray)
        {
            switch(Array.GetValue(Convert.ToInt32(MoveArray[1]), Convert.ToInt32(MoveArray[0])))
                {
                case "WB": 
                    Pawn pawn = new Pawn();
                    return pawn.CheckIfMoveLegalWhitePawn(MoveArray, Array);
                case "SB":
                    Pawn blackpawn = new Pawn();
                    return blackpawn.CheckIfMoveLegalBlackPawn(MoveArray, Array);
                case "WD":
                case "SD":
                    Queen queen = new Queen();
                    return queen.CheckIfMoveIsLegal(MoveArray);
                case "WT":
                case "ST":
                    Tower tower = new Tower();
                    return tower.CheckIfMoveIsLegal(MoveArray);
                case "WL":
                case "SL":
                    Bishop bishop  = new Bishop();
                    return bishop.CheckIfMoveIsLegal(MoveArray);
                case "WP":
                case "SP":
                    Knight knight = new Knight();
                    return knight.CheckIfMoveIsLegal(MoveArray);
                case "  ":
                default:
                    return false;
                }
        }
    }
}

