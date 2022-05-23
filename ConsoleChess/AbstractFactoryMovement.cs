using System;
using System.Collections.Generic;

namespace ConsoleChess
{
    abstract class Creator
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public Creator() { }
		public Creator(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}

        public abstract IProduct FactoryMethod();
		public bool MoveIsLegal(string[,] Playfield, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			var product = FactoryMethod();
			var result = product.MoveIsLegal(Playfield, OldNumber, OldLetter, NewNumber, NewLetter);
			return result;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			var product = FactoryMethod();
			var result = product.OwnKingIsThreaten(Playfield, KingPosition, Colour);
			return result;
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int [] KingPosition, string Colour)
		{
			var product = FactoryMethod();
			var result = product.OpponentKingIsThreaten(Playfield, KingPosition, Colour);
			return result;
		}
	}
	public interface IProduct
	{
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)  // check if own king is in mate / checkmate
		{
			return "  ";
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)  // check if own king is in mate / checkmate
		{
			return "  ";
		}
		public bool MoveIsLegal(string[,] Playfield, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			return false;
		}
	}
	class ConcreteCreatorKing : Creator
	{
		public ConcreteCreatorKing(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductKing(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorWhitePawn : Creator
	{
		public ConcreteCreatorWhitePawn(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductWhitePawn(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorBlackPawn : Creator
	{
		public ConcreteCreatorBlackPawn(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductBlackPawn(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorTower : Creator
	{
		public ConcreteCreatorTower(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductTower(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorKnight : Creator
	{
		public ConcreteCreatorKnight(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductKnight(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorBishop : Creator
	{
		public ConcreteCreatorBishop(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductBishop(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}
	class ConcreteCreatorQueen : Creator
	{
		public ConcreteCreatorQueen(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public override IProduct FactoryMethod()
		{
			return new ConcreteProductQueen(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
		}
	}






	class ConcreteProductKing : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductKing(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)  
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour) 
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}
		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalKing(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductWhitePawn : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductWhitePawn(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}

		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalPawn(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductBlackPawn : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductBlackPawn(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}

		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalPawn(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductTower : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductTower(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}
		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalStraight(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)    //Note: Bug which allow passing  first Piece in the way --> only Tower affected
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductKnight : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductKnight(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}
		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalKnight(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductBishop : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductBishop(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}
		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalDiagonal(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class ConcreteProductQueen : Pieces, IProduct
	{
		public string[,] Playfield { get; set; }
		public int[] KingPosition { get; set; }
		public int OldNumber { get; set; }
		public int OldLetter { get; set; }
		public int NewNumber { get; set; }
		public int NewLetter { get; set; }
		public string Colour { get; set; }
		public ConcreteProductQueen(string[,] _playfield, int[] _kingPosition, int _oldNumber, int _oldLetter, int _newNumber, int _newLetter, string _colour)
		{
			Playfield = _playfield;
			KingPosition = _kingPosition;
			OldNumber = _oldNumber;
			OldLetter = _oldLetter;
			NewNumber = _newNumber;
			NewLetter = _newLetter;
			Colour = _colour;
		}
		public string OwnKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OwnKingInMate(Playfield, KingPosition, Colour);
		}
		public string OpponentKingIsThreaten(string[,] Playfield, int[] KingPosition, string Colour)
		{
			return OpponentKingInMate(Playfield, KingPosition, Colour);
		}
		public bool MoveIsLegal(string[,] Array, int OldNumber, int OldLetter, int NewNumber, int NewLetter)
		{
			if (CheckIfMoveLegalStraight(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true ^ CheckIfMoveLegalDiagonal(Array, OldNumber, OldLetter, NewNumber, NewLetter) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	class Client
	{
        public bool CreatorMoveIsLegal(string[,] PlayfieldArray, int[] KingPosition, int OldNumber, int OldLetter, int NewNumber , int NewLetter, string Piece, string Colour, NewStruct newStruct)
		{
			if (Piece == "K")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorKing(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "P" && Colour == "W")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorWhitePawn(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "P" && Colour == "B")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorBlackPawn(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "T")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorTower(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "B")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorKnight(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "H")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorBishop(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour), newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			if (Piece == "Q")
				if (new Client().ProductMoveIsLegal(new ConcreteCreatorQueen(PlayfieldArray, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour),newStruct) == true)
					return true;
				else
				{
					Console.WriteLine("Zug ist ungültig \nBitte nochmal versuchen");
					return false;
				}
			else
			{
				Console.WriteLine("Es wurde keine gültige Figur ausgewählt \nBitte nochmal versuchen");
				return false;
			}

		}

		public bool ProductMoveIsLegal(Creator creator, NewStruct newStruct)
		{
			creator.Playfield = newStruct.Playfield;
			creator.KingPosition = newStruct.KingPosition;
			creator.OldLetter = newStruct.OldLetter;
			creator.OldNumber = newStruct.OldNumber;
			creator.NewLetter = newStruct.NewLetter;
			creator.NewNumber = newStruct.NewNumber;
			creator.Colour = newStruct.Colour;

			if (creator.OwnKingIsThreaten(creator.Playfield, creator.KingPosition, creator.Colour) == "N")			//Status "M" = Mate, Status "C" = Checkmate, Status "N" = No Mate
			{
				if(creator.OpponentKingIsThreaten(creator.Playfield, creator.KingPosition, creator.Colour) == "N")
                {
					return creator.MoveIsLegal(creator.Playfield, creator.OldNumber, creator.OldLetter, creator.NewNumber, creator.NewLetter);
                }
				else if (creator.OpponentKingIsThreaten(creator.Playfield, creator.KingPosition, creator.Colour) == "M")
				{
					Console.WriteLine("Gegnerischer König im Schach");
					return creator.MoveIsLegal(creator.Playfield, creator.OldNumber, creator.OldLetter, creator.NewNumber, creator.NewLetter);
				}
				else if (creator.OpponentKingIsThreaten(creator.Playfield, creator.KingPosition, creator.Colour) == "C")
				{
					Console.WriteLine("Gegnerischer König im Schachmatt");
					return creator.MoveIsLegal(creator.Playfield, creator.OldNumber, creator.OldLetter, creator.NewNumber, creator.NewLetter);
				}
				else
				{
					return false;
				}
			}
            else
			{
				Console.WriteLine("Eigener König im Schach");
				return false;
			}
		}
	}

    internal struct NewStruct
    {
        public string[,] Playfield;
        public int[] KingPosition;
        public int OldNumber;
        public int OldLetter;
        public int NewNumber;
        public int NewLetter;
        public string Colour;

        public NewStruct(string[,] playfield, int[] kingPosition, int oldNumber, int oldLetter, int newNumber, int newLetter, string colour)
        {
            Playfield = playfield;
            KingPosition = kingPosition;
            OldNumber = oldNumber;
            OldLetter = oldLetter;
            NewNumber = newNumber;
            NewLetter = newLetter;
            Colour = colour;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<string[,]>.Default.Equals(Playfield, other.Playfield) &&
                   EqualityComparer<int[]>.Default.Equals(KingPosition, other.KingPosition) &&
                   OldNumber == other.OldNumber &&
                   OldLetter == other.OldLetter &&
                   NewNumber == other.NewNumber &&
                   NewLetter == other.NewLetter &&
                   Colour == other.Colour;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Playfield, KingPosition, OldNumber, OldLetter, NewNumber, NewLetter, Colour);
        }

        public void Deconstruct(out string[,] playfield, out int[] kingPosition, out int oldNumber, out int oldLetter, out int newNumber, out int newLetter, out string colour)
        {
            playfield = Playfield;
            kingPosition = KingPosition;
            oldNumber = OldNumber;
            oldLetter = OldLetter;
            newNumber = NewNumber;
            newLetter = NewLetter;
            colour = Colour;
        }
        public static implicit operator (string[,] Playfield, int[] KingPosition, int OldNumber, int OldLetter, int NewNumber, int NewLetter, string Colour)(NewStruct value)
        {
            return (value.Playfield, value.KingPosition, value.OldNumber, value.OldLetter, value.NewNumber, value.NewLetter, value.Colour);
        }

        public static implicit operator NewStruct((string[,] Playfield, int[] KingPosition, int OldNumber, int OldLetter, int NewNumber, int NewLetter, string Colour) value)
        {
            return new NewStruct(value.Playfield, value.KingPosition, value.OldNumber, value.OldLetter, value.NewNumber, value.NewLetter, value.Colour);
        }
    }
}