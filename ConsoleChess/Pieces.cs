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
    public abstract class Pieces
    {
        public bool CheckIfMoveLegalPawn(string[,] Array, int OldNumber, int OldLetter, int NewNumber,  int NewLetter)
        {
            if (Array[OldNumber, OldLetter] == "WP" && NewNumber == OldNumber - 1 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (Array[OldNumber, OldLetter] == "WP" && NewNumber == OldNumber - 2 && OldNumber >= 6 && NewLetter == OldLetter && Array[NewNumber, NewLetter] == "  " && Array[NewNumber + 1, NewLetter] == "  ")
                return true;
            else if (Array[OldNumber, OldLetter] == "WP" && NewNumber == OldNumber - 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else if (Array[OldNumber, OldLetter] == "BP" && NewNumber == OldNumber - 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else if (Array[OldNumber, OldLetter] == "BP" && NewNumber == OldNumber + 2 && OldNumber <= 2 && NewLetter == OldLetter && Array[NewNumber - 1, NewLetter] == "  " && Array[NewNumber, NewLetter] == "  ")
                return true;
            else if (Array[OldNumber, OldLetter] == "BP" && NewNumber == OldNumber + 1 && NewLetter == OldLetter - 1 || NewLetter == OldLetter + 1 && Array[NewNumber, NewLetter] != "  ")
                return true;
            else return false;
        }

        public bool CheckIfMoveLegalStraight(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
        {
            if (
                OldLetter == NewLetter && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter && OldNumber == NewNumber + 2 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber + 3 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 2)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber + 4 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 3)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber + 5 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 4)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber + 6 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 5)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber + 7 && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber + 6)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter && OldNumber == NewNumber - 2 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 3 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 2)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 4 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 3)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 5 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 4)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 6 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 5)) != "  " ||
                OldLetter == NewLetter && OldNumber == NewNumber - 7 && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter, NewNumber - 6)) != "  " ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber ||
                OldLetter == NewLetter - 2 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " ||
                OldLetter == NewLetter - 3 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber)) != "  " ||
                OldLetter == NewLetter - 4 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber)) != "  " ||
                OldLetter == NewLetter - 5 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber)) != "  " ||
                OldLetter == NewLetter - 6 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber)) != "  " ||
                OldLetter == NewLetter - 7 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 6, NewNumber)) != "  " ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber ||
                OldLetter == NewLetter + 2 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " ||
                OldLetter == NewLetter + 3 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber)) != "  " ||
                OldLetter == NewLetter + 4 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber)) != "  " ||
                OldLetter == NewLetter + 5 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber)) != "  " ||
                OldLetter == NewLetter + 6 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber)) != "  " ||
                OldLetter == NewLetter + 7 && OldNumber == NewNumber && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 6, NewNumber)) != "  ")
                return true;
            else
                return false;
        }
        public bool CheckIfMoveLegalDiagonal(string[,] Array, int OldNumber,int OldLetter, int NewNumber,  int NewLetter)
        {
            if (
                OldLetter == NewLetter + 1 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter + 2 && OldNumber == NewNumber + 2 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " ||
                OldLetter == NewLetter + 3 && OldNumber == NewNumber + 3 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber + 2)) != "  " ||
                OldLetter == NewLetter + 4 && OldNumber == NewNumber + 4 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber + 3)) != "  " ||
                OldLetter == NewLetter + 5 && OldNumber == NewNumber + 5 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber + 4)) != "  " ||
                OldLetter == NewLetter + 6 && OldNumber == NewNumber + 6 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber + 5)) != "  " ||
                OldLetter == NewLetter + 7 && OldNumber == NewNumber + 7 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber + 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 6, NewNumber + 6)) != "  " ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter - 2 && OldNumber == NewNumber - 2 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " ||
                OldLetter == NewLetter - 3 && OldNumber == NewNumber - 3 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber - 2)) != "  " ||
                OldLetter == NewLetter - 4 && OldNumber == NewNumber - 4 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber - 3)) != "  " ||
                OldLetter == NewLetter - 5 && OldNumber == NewNumber - 5 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber - 4)) != "  " ||
                OldLetter == NewLetter - 6 && OldNumber == NewNumber - 6 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber - 5)) != "  " ||
                OldLetter == NewLetter - 7 && OldNumber == NewNumber - 7 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber - 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 6, NewNumber - 6)) != "  " ||
                OldLetter == NewLetter - 1 && OldNumber == NewNumber + 1 ||
                OldLetter == NewLetter - 2 && OldNumber == NewNumber + 2 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " ||
                OldLetter == NewLetter - 3 && OldNumber == NewNumber + 3 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber + 2)) != "  " ||
                OldLetter == NewLetter - 4 && OldNumber == NewNumber + 4 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber + 3)) != "  " ||
                OldLetter == NewLetter - 5 && OldNumber == NewNumber + 5 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber + 4)) != "  " ||
                OldLetter == NewLetter - 6 && OldNumber == NewNumber + 6 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber + 5)) != "  " ||
                OldLetter == NewLetter - 7 && OldNumber == NewNumber + 7 && Convert.ToString(Array.GetValue(NewLetter - 1, NewNumber + 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 2, NewNumber + 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 3, NewNumber + 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 4, NewNumber + 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 5, NewNumber + 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter - 6, NewNumber + 6)) != "  " ||
                OldLetter == NewLetter + 1 && OldNumber == NewNumber - 1 ||
                OldLetter == NewLetter + 2 && OldNumber == NewNumber - 2 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " ||
                OldLetter == NewLetter + 3 && OldNumber == NewNumber - 3 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber - 2)) != "  " ||
                OldLetter == NewLetter + 4 && OldNumber == NewNumber - 4 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber - 3)) != "  " ||
                OldLetter == NewLetter + 5 && OldNumber == NewNumber - 5 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber - 4)) != "  " ||
                OldLetter == NewLetter + 6 && OldNumber == NewNumber - 6 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber - 5)) != "  " ||
                OldLetter == NewLetter + 7 && OldNumber == NewNumber - 7 && Convert.ToString(Array.GetValue(NewLetter + 1, NewNumber - 1)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 2, NewNumber - 2)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 3, NewNumber - 3)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 4, NewNumber - 4)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 5, NewNumber - 5)) != "  " && Convert.ToString(Array.GetValue(NewLetter + 6, NewNumber - 6)) != "  ")
                return true;
            else
                return false;
        }
        public bool CheckIfMoveLegalKing(string[,] Array, int OldNumber, int OldLetter, int NewNumber,  int NewLetter) //the proving of the case "the king is in a mate with a move" is missing 
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
        public bool CheckIfMoveLegalKnight(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter) 
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
        private bool IsKingInMateWhite(string[,] Array, int whiteKingNumber, int whiteKingLetter)
        {
            string s1;
            string s2;
                for (int i = whiteKingLetter + 1; i < 8; i++)
                {
                    if (Array.GetValue(whiteKingNumber, i) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber, i);
                        if (s1 != "W")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, whiteKingNumber, i);
                            if (s2 == "Q" || s2 == "T")
                            {
                                return true;
                            }
                            else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = 9;
                            }
                        }
                        else if (s1 == "W")
                        {
                            i = 9;
                        }
                    }
                }
                for (int i = whiteKingLetter - 1; i > -1; i--)
                {
                    if (Array.GetValue(whiteKingNumber, i) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber, i);
                        if (s1 != "W")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, whiteKingNumber, i);
                            if (s2 == "Q" || s2 == "T")
                            {
                            return true;
                        }
                            else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = -1;
                            }
                        }
                        else if (s1 == "W")
                        {
                            i = -1;
                        }
                    }
                }
                for (int i = whiteKingNumber + 1; i < 8; i++)
                {
                    if (Array.GetValue(i, whiteKingLetter) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, whiteKingLetter);
                        if (s1 != "W")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, whiteKingLetter);
                            if (s2 == "Q" || s2 == "T")
                            {
                                return true;
                            }
                            else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = 9;
                            }
                        }
                        else if (s1 == "W")
                        {
                            i = 9;
                        }
                    }
                }
                for (int i = whiteKingNumber - 1; i > -1; i--)
                {
                    if (Array.GetValue(i, whiteKingLetter) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, whiteKingLetter);
                        if (s1 != "W")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, whiteKingLetter);
                            if (s2 == "Q" || s2 == "T")
                            {
                            return true;
                            }
                            else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = -1;
                            }
                        }
                        else if (s1 == "W")
                        {
                            i = -1;
                        }
                    }
                }
                for (int i = whiteKingNumber + 1; i < 8; i++)
                {
                    for (int j = whiteKingLetter + 1; j < 8; j++)
                    {
                        if (Array.GetValue(i, j) != "  ")
                        {
                            s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                            if (s1 != "W")
                            {
                                s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                                if (s2 == "Q" || s2 == "B")
                                {
                                    return true;
                                }
                                else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                                {
                                    i = 9;
                                    j = 9;
                                }
                            }
                            else if (s1 == "W")
                            {
                                i = 9;
                                j = 9;
                            }
                        }
                    }
                }
                for (int i = whiteKingNumber - 1; i > -1; i--)
                {
                    for (int j = whiteKingLetter - 1; j > -1; j--)
                    {
                        if (Array.GetValue(i, j) != "  ")
                        {
                            s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                            if (s1 != "W")
                            {
                                s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                                if (s2 == "Q" || s2 == "B")
                                {
                                    return true;
                                }
                                else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                                {
                                    i = -1;
                                    j = -1;
                                }
                            }
                            else if (s1 == "W")
                            {
                                i = -1;
                                j = -1;
                            }
                        }
                    }
                }
                for (int i = whiteKingNumber - 1; i > -1; i--)
                {
                    for (int j = whiteKingLetter + 1; j < 8; j++)
                    {
                        if (Array.GetValue(i, j) != "  ")
                        {
                            s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                            if (s1 != "W")
                            {
                                s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                                if (s2 == "Q" || s2 == "B")
                                {
                                    return true;
                                }
                                else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                                {
                                    i = -1;
                                    j = 9;
                                }
                            }
                            else if (s1 == "W")
                            {
                                i = -1;
                                j = 9;
                            }
                        }
                    }
                }
                for (int i = whiteKingNumber + 1; i < 8; i++)
                {
                    for (int j = whiteKingLetter - 1; j > -1; j--)
                    {
                        if (Array.GetValue(i, j) != "  ")
                        {
                            s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                            if (s1 != "W")
                            {
                                s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                                if (s2 == "Q" || s2 == "B")
                                {
                                    return true;
                                }
                                else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                                {
                                    i = 9;
                                    j = -1;
                                }
                            }
                            else if (s1 == "W")
                            {
                                i = 9;
                                j = -1;
                            }
                        }
                    }
                }
                if (whiteKingNumber >= 2 && whiteKingNumber <= 5 && whiteKingLetter >= 2 && whiteKingLetter <= 5) //middle
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                    {
                        return true;
                    }
                }
                else if (whiteKingNumber == 0 && whiteKingLetter >= 2 && whiteKingLetter <= 5) //border
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK")
                    {
                        return true;
                    }
                }
                else if (whiteKingNumber == 1 && whiteKingLetter >= 2 && whiteKingLetter <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                    Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                    Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||

                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                    {
                        return true;
                    }
                }
                else if (whiteKingNumber == 6 && whiteKingLetter >= 2 && whiteKingLetter <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                    Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                    {
                        return true;
                    }
                }
                else if (whiteKingNumber == 7 && whiteKingLetter >= 2 && whiteKingLetter <= 5)
                {
                    if (Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                    Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                    Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                    Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                    {
                        return true;
                    }
                }
                else if (whiteKingLetter == 0 && whiteKingNumber >= 2 && whiteKingNumber <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingLetter == 1 && whiteKingNumber >= 2 && whiteKingNumber <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingLetter == 6 && whiteKingNumber >= 2 && whiteKingNumber <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingLetter == 7 && whiteKingNumber >= 2 && whiteKingNumber <= 5)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }


                else if (whiteKingNumber == 0 && whiteKingLetter == 0)  //NW corner
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK")
                    {
                        return true;
                    }
                }
                else if (whiteKingNumber == 0 && whiteKingLetter == 1)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 1 && whiteKingLetter == 0)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 1 && whiteKingLetter == 1)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }

                else if (whiteKingNumber == 0 && whiteKingLetter == 7)  //NE corner
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 0 && whiteKingLetter == 6)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK")
                    {
                        return true;
                    }
                }

                else if (whiteKingNumber == 1 && whiteKingLetter == 6)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 1 && whiteKingLetter == 7)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber + 2, whiteKingLetter - 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 7 && whiteKingLetter == 0)  //SW corner
                {
                    if (Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 7 && whiteKingLetter == 1)
                {
                    if (Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 6 && whiteKingLetter == 0)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 6 && whiteKingLetter == 1)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }

                else if (whiteKingNumber == 7 && whiteKingLetter == 7)  //SE corner
                {
                    if (Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 7 && whiteKingLetter == 6)
                {
                    if (Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }
                else if (whiteKingNumber == 6 && whiteKingLetter == 7)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter - 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }

                }

                else if (whiteKingNumber == 6 && whiteKingLetter == 6)
                {
                    if (Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 2) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||
                        Array.GetValue(whiteKingNumber - 2, whiteKingLetter + 1) == "BH" ||

                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber + 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter + 1) == "BK" ||
                        Array.GetValue(whiteKingNumber, whiteKingLetter - 1) == "BK" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter + 1) == "BP" ||
                        Array.GetValue(whiteKingNumber - 1, whiteKingLetter - 1) == "BP")
                        {
                            return true;
                        }
                }            
            return false;
        }
        private bool IsKingInMateBlack(string[,] Array, int blackKingNumber, int blackKingLetter)
        {
            string s1;
            string s2;
            for (int i = blackKingLetter + 1; i < 8; i++)
            {
                if (Array.GetValue(blackKingNumber, i) != "  ")
                {
                    s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber, i);
                    if (s1 != "B")
                    {
                        s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, blackKingNumber, i);
                        if (s2 == "Q" || s2 == "T")
                        {
                            return true;
                        }
                        else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                        {
                            i = 9;
                        }
                    }
                    else if (s1 == "B")
                    {
                        i = 9;
                    }
                }
            }
            for (int i = blackKingLetter - 1; i > -1; i--)
            {
                if (Array.GetValue(blackKingNumber, i) != "  ")
                {
                    s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber, i);
                    if (s1 != "B")
                    {
                        s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, blackKingNumber, i);
                        if (s2 == "Q" || s2 == "T")
                        {
                            return true;
                        }
                        else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                        {
                            i = -1;
                        }
                    }
                    else if (s1 == "B")
                    {
                        i = -1;
                    }
                }
            }
            for (int i = blackKingNumber + 1; i < 8; i++)
            {
                if (Array.GetValue(i, blackKingLetter) != "  ")
                {
                    s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, blackKingLetter);
                    if (s1 != "B")
                    {
                        s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, blackKingLetter);
                        if (s2 == "Q" || s2 == "T")
                        {
                            return true;
                        }
                        else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                        {
                            i = 9;
                        }
                    }
                    else if (s1 == "B")
                    {
                        i = 9;
                    }
                }
            }
            for (int i = blackKingNumber - 1; i > -1; i--)
            {
                if (Array.GetValue(i, blackKingLetter) != "  ")
                {
                    s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, blackKingLetter);
                    if (s1 != "B")
                    {
                        s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, blackKingLetter);
                        if (s2 == "Q" || s2 == "T")
                        {
                            return true;
                        }
                        else if (s2 == "B" || s2 == "H" || s2 == "P" || s2 == "K")
                        {
                            i = -1;
                        }
                    }
                    else if (s1 == "B")
                    {
                        i = -1;
                    }
                }
            }
            for (int i = blackKingNumber + 1; i < 8; i++)
            {
                for (int j = blackKingLetter + 1; j < 8; j++)
                {
                    if (Array.GetValue(i, j) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                        if (s1 != "B")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                            if (s2 == "Q" || s2 == "B")
                            {
                                return true;
                            }
                            else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = 9;
                                j = 9;
                            }
                        }
                        else if (s1 == "B")
                        {
                            i = 9;
                            j = 9;
                        }
                    }
                }
            }
            for (int i = blackKingNumber - 1; i > -1; i--)
            {
                for (int j = blackKingLetter - 1; j > -1; j--)
                {
                    if (Array.GetValue(i, j) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                        if (s1 != "B")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                            if (s2 == "Q" || s2 == "B")
                            {
                                return true;
                            }
                            else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = -1;
                                j = -1;
                            }
                        }
                        else if (s1 == "B")
                        {
                            i = -1;
                            j = -1;
                        }
                    }
                }
            }
            for (int i = blackKingNumber - 1; i > -1; i--)
            {
                for (int j = blackKingLetter + 1; j < 8; j++)
                {
                    if (Array.GetValue(i, j) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                        if (s1 != "B")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                            if (s2 == "Q" || s2 == "B")
                            {
                                return true;
                            }
                            else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = -1;
                                j = 9;
                            }
                        }
                        else if (s1 == "B")
                        {
                            i = -1;
                            j = 9;
                        }
                    }
                }
            }
            for (int i = blackKingNumber + 1; i < 8; i++)
            {
                for (int j = blackKingLetter - 1; j > -1; j--)
                {
                    if (Array.GetValue(i, j) != "  ")
                    {
                        s1 = Playfield.playfield.GetFirstLetterOfPiece(Array, i, j);
                        if (s1 != "B")
                        {
                            s2 = Playfield.playfield.GetSecondLetterOfPiece(Array, i, j);
                            if (s2 == "Q" || s2 == "B")
                            {
                                return true;
                            }
                            else if (s2 == "T" || s2 == "H" || s2 == "P" || s2 == "K")
                            {
                                i = 9;
                                j = -1;
                            }
                        }
                        else if (s1 == "B")
                        {
                            i = 9;
                            j = -1;
                        }
                    }
                }
            }
            if (blackKingNumber >= 2 && blackKingNumber <= 5 && blackKingLetter >= 2 && blackKingLetter <= 5) //middle
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "BK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 0 && blackKingLetter >= 2 && blackKingLetter <= 5) //border
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 1 && blackKingLetter >= 2 && blackKingLetter <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||

                Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 6 && blackKingLetter >= 2 && blackKingLetter <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 7 && blackKingLetter >= 2 && blackKingLetter <= 5)
            {
                if (Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK")
                {
                    return true;
                }
            }
            else if (blackKingLetter == 0 && blackKingNumber >= 2 && blackKingNumber <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingLetter == 1 && blackKingNumber >= 2 && blackKingNumber <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingLetter == 6 && blackKingNumber >= 2 && blackKingNumber <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingLetter == 7 && blackKingNumber >= 2 && blackKingNumber <= 5)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }


            else if (blackKingNumber == 0 && blackKingLetter == 0)  //NW corner
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 0 && blackKingLetter == 1)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 1 && blackKingLetter == 0)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 1 && blackKingLetter == 1)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }

            else if (blackKingNumber == 0 && blackKingLetter == 7)  //NE corner
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 0 && blackKingLetter == 6)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }

            else if (blackKingNumber == 1 && blackKingLetter == 6)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 1 && blackKingLetter == 7)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber + 2, blackKingLetter - 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 7 && blackKingLetter == 0)  //SW corner
            {
                if (Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 7 && blackKingLetter == 1)
            {
                if (Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 6 && blackKingLetter == 0)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 6 && blackKingLetter == 1)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }

            else if (blackKingNumber == 7 && blackKingLetter == 7)  //SE corner
            {
                if (Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 7 && blackKingLetter == 6)
            {
                if (Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK")
                {
                    return true;
                }
            }
            else if (blackKingNumber == 6 && blackKingLetter == 7)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter - 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }

            }

            else if (blackKingNumber == 6 && blackKingLetter == 6)
            {
                if (Array.GetValue(blackKingNumber + 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 2) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||
                    Array.GetValue(blackKingNumber - 2, blackKingLetter + 1) == "WH" ||

                    Array.GetValue(blackKingNumber + 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber - 1, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter + 1) == "WK" ||
                    Array.GetValue(blackKingNumber, blackKingLetter - 1) == "WK" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter + 1) == "WP" ||
                    Array.GetValue(blackKingNumber + 1, blackKingLetter - 1) == "WP")
                {
                    return true;
                }
            }
            return false;
        }
        public string OwnKingInMate(string[,] Array, int[] KingPosition, string Colour)
        {
            int whiteKingLetter = Convert.ToInt32(KingPosition.GetValue(0));
            int whiteKingNumber = Convert.ToInt32(KingPosition.GetValue(1));
            int blackKingLetter = Convert.ToInt32(KingPosition.GetValue(2));
            int blackKingNumber = Convert.ToInt32(KingPosition.GetValue(3));
            if (Colour == "W")
            {
                if (IsKingInMateWhite(Array, whiteKingNumber, whiteKingLetter) == true)
                {
                    return "C";
                }
            }
            if (Colour == "B")
            {
                if (IsKingInMateBlack(Array, blackKingNumber, blackKingLetter) == true)
                {
                    return "C";
                }
            }
            return "N";
        }
        public string OpponentKingInMate(string[,] Array, int[] KingPosition, string Colour)
        {
            int whiteKingLetter = Convert.ToInt32(KingPosition.GetValue(0));
            int whiteKingNumber = Convert.ToInt32(KingPosition.GetValue(1));
            int blackKingLetter = Convert.ToInt32(KingPosition.GetValue(2));
            int blackKingNumber = Convert.ToInt32(KingPosition.GetValue(3));

            if (Colour == "W")
            {
                int checkmateCounter = 0;
                string N;
                string NE;
                string E;
                string SE;
                string S;
                string SW;
                string W;
                string NW;
                if (whiteKingNumber != 0)
                {               
                    N = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber - 1, whiteKingLetter);
                }
                else
                {
                    N = "X";
                }
                if (whiteKingNumber != 0 && whiteKingLetter != 7)
                {
                    NE = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber - 1, whiteKingLetter + 1);
                }
                else
                {
                    NE = "X";
                }
                if (whiteKingLetter != 7)
                {
                    E = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber, whiteKingLetter + 1);
                }
                else
                {
                    E = "X";
                }
                if (whiteKingNumber != 7 && whiteKingLetter != 7)
                {
                    SE = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber + 1, whiteKingLetter + 1);
                }
                else
                {
                    SE = "X";
                }
                if (whiteKingNumber != 7)
                {
                    S = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber + 1, whiteKingLetter);
                }
                else
                {
                    S = "X";
                }
                if (whiteKingNumber != 7 && whiteKingLetter != 0)
                {
                    SW = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber + 1, whiteKingLetter - 1);
                }
                else
                {
                    SW = "X";
                }
                if (whiteKingLetter != 0)
                {
                    W = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber, whiteKingLetter - 1);
                }
                else
                {
                    W = "X";
                }
                if (whiteKingNumber != 0 && whiteKingLetter != 0)
                {
                    NW = Playfield.playfield.GetFirstLetterOfPiece(Array, whiteKingNumber - 1, whiteKingLetter - 1);
                }
                else
                {
                    NW = "X";
                }




                if (IsKingInMateWhite(Array, whiteKingNumber, whiteKingLetter) == false )
                {
                    return "N";
                }
                else if (IsKingInMateWhite(Array, whiteKingNumber, whiteKingLetter) == true)
                {
                    if(N != "X")
                    {
                        if(IsKingInMateWhite(Array, whiteKingNumber - 1, whiteKingLetter) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (NE != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber - 1, whiteKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (E != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber, whiteKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (SE != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber + 1, whiteKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (S != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber + 1, whiteKingLetter) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (SW != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber + 1, whiteKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (W != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber, whiteKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (NW != "X")
                    {
                        if (IsKingInMateWhite(Array, whiteKingNumber - 1, whiteKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (checkmateCounter == 8)
                    {
                        return "C";
                    }
                    return "M";
                }
            }
            if (Colour == "B")
            {
                int checkmateCounter = 0;
                string N;
                string NE;
                string E;
                string SE;
                string S;
                string SW;
                string W;
                string NW;
                if (blackKingNumber != 0)
                {
                    N = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber - 1, blackKingLetter);
                }
                else
                {
                    N = "X";
                }
                if (blackKingNumber != 0 && blackKingLetter != 7)
                {
                    NE = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber - 1, blackKingLetter + 1);
                }
                else
                {
                    NE = "X";
                }
                if (blackKingLetter != 7)
                {
                    E = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber, blackKingLetter + 1);
                }
                else
                {
                    E = "X";
                }
                if (blackKingNumber != 7 && blackKingLetter != 7)
                {
                    SE = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber + 1, blackKingLetter + 1);
                }
                else
                {
                    SE = "X";
                }
                if (blackKingNumber != 7)
                {
                    S = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber + 1, blackKingLetter);
                }
                else
                {
                    S = "X";
                }
                if (blackKingNumber != 7 && blackKingLetter != 0)
                {
                    SW = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber + 1, blackKingLetter - 1);
                }
                else
                {
                    SW = "X";
                }
                if (blackKingLetter != 0)
                {
                    W = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber, blackKingLetter - 1);
                }
                else
                {
                    W = "X";
                }
                if (blackKingNumber != 0 && blackKingLetter != 0)
                {
                    NW = Playfield.playfield.GetFirstLetterOfPiece(Array, blackKingNumber - 1, blackKingLetter - 1);
                }
                else
                {
                    NW = "X";
                }




                if (IsKingInMateWhite(Array, blackKingNumber, blackKingLetter) == false)
                {
                    return "N";
                }
                else if (IsKingInMateWhite(Array, blackKingNumber, blackKingLetter) == true)
                {
                    if (N != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber - 1, blackKingLetter) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (NE != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber - 1, blackKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (E != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber, blackKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (SE != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber + 1, blackKingLetter + 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (S != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber + 1, blackKingLetter) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (SW != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber + 1, blackKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (W != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber, blackKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (NW != "X")
                    {
                        if (IsKingInMateWhite(Array, blackKingNumber - 1, blackKingLetter - 1) == true)
                        {
                            checkmateCounter += 1;
                        }
                    }
                    if (checkmateCounter == 8)
                    {
                        return "C";
                    }
                    return "M";
                }
            }
            return "N";
        }
    }
}
