using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class ChessPieceFactory : IChessPieceFactory
    {
        private class FaultPiece : IChessPiece
        {
            public bool IsWhite { get; }
            public bool CheckIfMoveIsLegal(string[,] Array, int OldLetter, int OldNumber, int NewLetter, int NewNumber)
            {
                return false;
            }
        }

        private IDictionary<string, IChessPiece> chessPieces = new Dictionary<string, IChessPiece>();
        private static IChessPiece FaultPieceItem = new FaultPiece();

        public ChessPieceFactory()
        {
            chessPieces.Add("ST", new Tower(false));
            chessPieces.Add("SL", new Knight(false));
            chessPieces.Add("SS", new Bishop(false));
            chessPieces.Add("SD", new Queen(false));
            chessPieces.Add("SK", new King(false));
            chessPieces.Add("SB", new Pawn(false));

            chessPieces.Add("WT", new Tower(true));
            chessPieces.Add("WL", new Knight(true));
            chessPieces.Add("WS", new Bishop(true));
            chessPieces.Add("WD", new Queen(true));
            chessPieces.Add("WK", new King(true));
            chessPieces.Add("WB", new Pawn(true));
        }

        public IChessPiece GetPiece(string pieceKey)
        {
            if (!chessPieces.TryGetValue(pieceKey, out var piece))
                return FaultPieceItem;
            return piece;
        }
    }
}