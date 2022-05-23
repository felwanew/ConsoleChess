using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleChess
{
    public class Playfield
    {
        private Playfield() { }
        public static Playfield playfield;
        private static readonly object _lock = new object();

        public bool WhiteKingAlive = true;
        public bool BlackKingAlive = true;

        public int Round = 0;
        public string[,] PlayfieldInternal = new string[8, 8]
        {
            { "BT", "BH", "BB", "BQ", "BK", "BB", "BH", "BT"},
            { "BP", "BP", "BP", "BP", "BP", "BP", "BP", "BP"},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            { "WP", "WP", "WP", "WP", "WP", "WP", "WP", "WP"},
            { "WT", "WH", "WB", "WQ", "WK", "WB", "WH", "WT"}
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
                    Console.Write(PlayfieldInternal[i, j] + "|");
                }
                Console.WriteLine(number - i);
                Console.WriteLine(" " + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + "--" + "+" + " ");
            }
            Console.WriteLine(" " + "+" + "A " + "+" + "B " + "+" + "C " + "+" + "D " + "+" + "E " + "+" + "F " + "+" + "G " + "+" + "H " + "+" + " ");
        }
        public string[,] ChangePlayfield(string[,] PlayfieldArray, string[] MoveArray, int[] KingPosition) //muss zwei Variablen zurückgeben: einmal ob der Zug an sich legal ist (bool) und andererseits, ob der König bedroht wird (string, da wir noch den Fall haben können, dass ein Zug den König ins Schachmatt setzt) 
        {   

            int OldLetter = CompareLetter(Convert.ToString(MoveArray.GetValue(0)));
            int OldNumber = CompareNumber(Convert.ToString(MoveArray.GetValue(1)));
            int NewLetter = CompareLetter(Convert.ToString(MoveArray.GetValue(2)));
            int NewNumber = CompareNumber(Convert.ToString(MoveArray.GetValue(3)));

            string Piece = GetSecondLetterOfPiece(PlayfieldArray, OldNumber, OldLetter);
            string Colour = GetFirstLetterOfPiece(PlayfieldArray, OldNumber, OldLetter);
            if (Round % 2 == 0 && Colour == "B" ^ Round % 2 == 1 && Colour == "W")
            {
                Console.WriteLine("Ziehen mit den Gegner-Steinen nicht möglich");
                return PlayfieldArray;
            }

            NewStruct newStruct = new NewStruct(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
            Client client = new Client();
            bool var = client.CreatorMoveIsLegal(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Piece, Colour, newStruct);

            if (var == true)
            {
                playfield.PlayfieldInternal = playfield.DoMove(OldLetter, OldNumber, NewLetter, NewNumber);
                playfield.Round++;
            }
            return PlayfieldArray;
        }
        private int CompareLetter(string MoveArray)
        {
            int Letter = MoveArray switch
            {
                "A" => 0,
                "B" => 1,
                "C" => 2,
                "D" => 3,
                "E" => 4,
                "F" => 5,
                "G" => 6,
                "H" => 7,
                _ => -1,//error if -1
            };
            return Letter;
        }
        private int CompareNumber(string MoveArray)
        {
            int Number = MoveArray switch
            {
                "1" => 7,
                "2" => 6,
                "3" => 5,
                "4" => 4,
                "5" => 3,
                "6" => 2,
                "7" => 1,
                "8" => 0,
                _ => -1,//error if -1
            };
            return Number;
        }
        public string[,] DoMove(int OldLetter, int OldNumber, int NewLetter, int NewNumber)
        {
            playfield.PlayfieldInternal[NewNumber, NewLetter] = playfield.PlayfieldInternal[OldNumber, OldLetter];
            playfield.PlayfieldInternal[OldNumber, OldLetter] = "  ";
            return PlayfieldInternal;             
        }
        public string GetFieldID(int OldLetter, int OldNumber)
        {
            return (playfield.PlayfieldInternal.GetValue(OldNumber, OldLetter)) switch
            {
                "WP" => "WP",
                "BP" => "BP",
                "WQ" => "WQ",
                "BQ" => "BQ",
                "WT" => "WT",
                "BT" => "BT",
                "WB" => "WB",
                "BB" => "BB",
                "WH" => "WH",
                "BH" => "BH",
                "WK" => "WK",
                "BK" => "BK",
                _ => "  ",
            };
        }
        public string GetFirstLetterOfPiece(string[,] MoveArray, int Number, int Letter) //e.g. W for White or B for Black
        {
                string s1 = Convert.ToString(MoveArray.GetValue(Number, Letter));
                return s1.Substring(0, 1);
        }
        public string GetSecondLetterOfPiece(string[,] MoveArray, int Number, int Letter) //e.g. W for White or B for Black
        {
            string s1 = Convert.ToString(MoveArray.GetValue(Number, Letter));
            return s1.Substring(1, 1);
        }

        public int[] WhereIsKing(int[] KingPosition)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (playfield.PlayfieldInternal[i, j] == "WK")
                    {
                        KingPosition[0] = i;
                        KingPosition[1] = j;
                    }
                    if (playfield.PlayfieldInternal[i, j] == "BK")
                    {
                        KingPosition[2] = i;
                        KingPosition[3] = j;
                    }
                }
            }
            return KingPosition;
        }
        public static Playfield GetInstance()
        {
            if (playfield == null)
            {
                lock (_lock)
                {
                    if (playfield == null)
                    {
                        playfield = new Playfield();
                    }
                }
            }
            return playfield;
        }
    }

}

