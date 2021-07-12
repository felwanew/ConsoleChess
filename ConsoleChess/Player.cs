using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Player
    {
        public string Name { get; set; }
        public string FullName { get; }
        public bool IsWhite { get; set; }
        public Player(string _name, bool _isWhite)
        {
            Name = _name;
            IsWhite = _isWhite;
            FullName = Name + (_isWhite ? " (Weiß)" : " (Schwarz)");
        }
    }
}
