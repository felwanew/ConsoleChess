using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public interface IChessPieceFactory
    {
        IChessPiece GetPiece(string pieceKey);
    }
}
