using System;

namespace ConsoleChess
{
    public static class Playfield
    {
        private static IChessPieceFactory pieceFactory = new ChessPieceFactory();

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

        public static void ShowPlayfield()
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
        public static bool ChangePlayfield(string[] MoveArray, Player player)
        {
            int OldLetter = ConvertLetterToColumnNumber(Convert.ToString(MoveArray.GetValue(0)));
            if (OldLetter < 0)
                return false;
            int OldNumber = ConvertNumberStringToNumber(Convert.ToString(MoveArray.GetValue(1)));
            if (OldNumber < 0)
                return false;
            int NewLetter = ConvertLetterToColumnNumber(Convert.ToString(MoveArray.GetValue(2)));
            if (NewLetter < 0)
                return false;
            int NewNumber = ConvertNumberStringToNumber(Convert.ToString(MoveArray.GetValue(3)));
            if (NewNumber < 0)
                return false;


            bool moveLegal = CheckIfMoveIsLegal(PlayfieldArray, OldLetter, OldNumber, NewLetter, NewNumber, player);
            if (moveLegal == true)
            {
                DoMove(PlayfieldArray, OldLetter, OldNumber, NewLetter, NewNumber);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static int ConvertLetterToColumnNumber(string letter)
        {
            var number = letter[0] - 'A';
            if (number > 7 || number < -1)
                return -1;
            return number;
        }

        private static int ConvertNumberStringToNumber(string numberString)
        {
            var number = 8 - (numberString[0] - '0');
            if (number > 7 || number < -1)
                return -1;
            return number;
        }

        public static string[,] DoMove(string[,] PlayfieldArray, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            PlayfieldArray[NewNumber, NewLetter] = PlayfieldArray[OldNumber, OldLetter];
            PlayfieldArray[OldNumber, OldLetter] = "  ";
            return PlayfieldArray;
        }
        public static bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber, Player player)
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
            var piece = pieceFactory.GetPiece(Array.GetValue(OldNumber, OldLetter).ToString());
            if (piece.IsWhite != player.IsWhite)
                return false;
            return piece.CheckIfMoveIsLegal(Array, OldLetter, OldNumber, NewLetter, NewNumber);
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

