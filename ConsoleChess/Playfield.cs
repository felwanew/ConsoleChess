using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleChess
{
    public static class Playfield
    {
        public static string[,] PlayfieldArray = new string[8, 8]
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
        public static void CreatePlayfield()
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
        public static string[,] ChangePlayfield(string[,] PlayfieldArray, string[] MoveArray)
        {
            int OldLetter = CompareLetter(Convert.ToString(MoveArray.GetValue(0)));
            int OldNumber = CompareNumber(Convert.ToString(MoveArray.GetValue(1)));
            int NewLetter = CompareLetter(Convert.ToString(MoveArray.GetValue(2)));
            int NewNumber = CompareNumber(Convert.ToString(MoveArray.GetValue(3)));

            
            bool moveLegal = CheckIfMoveIsLegal(PlayfieldArray, OldLetter, OldNumber, NewLetter, NewNumber);
            if (moveLegal == true)
            {
                 DoMove(PlayfieldArray, OldLetter, OldNumber, NewLetter, NewNumber);
            }
            else
            {
                Console.WriteLine("Zug ungültig");
            }
            return PlayfieldArray;
        }
        private static int CompareLetter(string MoveArray)
        {
            int Letter;
            switch (MoveArray)
            {
                case "A":
                    Letter = 0;
                    break;
                case "B":
                    Letter = 1;
                    break;
                case "C":
                    Letter = 2;
                    break;
                case "D":
                    Letter = 3;
                    break;
                case "E":
                    Letter = 4;
                    break;
                case "F":
                    Letter = 5;
                    break;
                case "G":
                    Letter = 6;
                    break;
                case "H":
                    Letter = 7;
                    break;
                default:
                    Letter = -1; //error if -1
                    break;
            }
            return Letter;
        }
        private static int CompareNumber(string MoveArray)
        {
            int Number;
        switch (MoveArray)
            {
            case "1":
                Number = 7;
                break;
            case "2":
                Number = 6;
                break;
            case "3":
                Number = 5;
                break;
            case "4":
                Number = 4;
                break;
            case "5":
                Number = 3;
                break;
            case "6":
                Number = 2;
                break;
            case "7":
                Number = 1;
                break;
            case "8":
                Number = 0;
                break;
            default:
                Number = -1; //error if -1
                break;
            }
        return Number;
        }
        public static string [,] DoMove(string[,] PlayfieldArray, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            PlayfieldArray[NewNumber, NewLetter] = PlayfieldArray[OldNumber,OldLetter];
            PlayfieldArray[OldNumber, OldLetter] = "  ";
            return PlayfieldArray;
        }
        public static bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            //string s1 = Convert.ToString(Array.GetValue(OldNumber, OldLetter));
            //string s2 = Convert.ToString(Array.GetValue(NewNumber, NewLetter));
            string substring1 = GetFirstLetterOfPiece(Array, OldNumber, OldLetter);
            string substring2 = GetFirstLetterOfPiece(Array, NewNumber, NewLetter);

            if (substring1 == substring2) //Check if figure is Occupied by own figure
            {
                Console.WriteLine("Schlagen eigener Figuren ist nicht möglich");
                return false;
            }
            Checkoccupation(Array, OldLetter, OldNumber, NewLetter, NewNumber);
            switch (Array.GetValue(OldNumber, OldLetter))
            {
                case "WB": 
                    Pawn pawn = new Pawn();
                    return pawn.CheckIfMoveLegalWhitePawn(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "SB":
                    Pawn blackpawn = new Pawn();
                    return blackpawn.CheckIfMoveLegalBlackPawn(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "WD":
                case "SD":
                    Queen queen = new Queen();
                    return queen.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "WT":
                case "ST":
                    Tower tower = new Tower();
                    return tower.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "WL":
                case "SL":
                    Bishop bishop  = new Bishop();
                    return bishop.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "WS":
                case "SS":
                    Knight knight = new Knight();
                    return knight.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "WK":
                case "SK":
                    King king = new King();
                    return king.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
                case "  ":
                default:
                    return false;
            }

        }

        static void Checkoccupation(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber) 
        {
            string s1 = Convert.ToString(Array.GetValue(OldNumber, OldLetter));
            string s2 = Convert.ToString(Array.GetValue(NewNumber, NewLetter));
            string substring1 = GetFirstLetterOfPiece(Array, OldNumber, OldLetter);
            string substring2 = GetFirstLetterOfPiece(Array, NewNumber, NewLetter);
        }

        static bool Mate(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            return true;
        }
        static bool Checkmate(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            return true;
        }

        private static string GetFirstLetterOfPiece(string[,] Array, int Number, int Letter) //e.g. W for White or B for Black
        {
            string s1 = Convert.ToString(Array.GetValue(Number, Letter));
            return s1.Substring(0, 1);
        }
    }
}

