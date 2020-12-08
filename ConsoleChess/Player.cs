using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    public class Player
    {
        public string Name { get; set; }
        public Player(string _name)
        {
            Name = _name;
        }
        public string AskPlayerToMove(string Player)
        {
            return Player + " du bist am Zug";
        }
        public static string[] Move()
        {
            string movefrom = Console.ReadLine();
            string moveto = Console.ReadLine();
            string[] array = new string[] { movefrom.Substring(0, 1), movefrom.Substring(1, 1), moveto.Substring(0, 1), moveto.Substring(1, 1) }; //fängt zu lange Abfragen ab z.B. F321ve = F3
            Console.WriteLine(array[0]+ " " + array[1] + " " + array[2] + " " + array[3]);
            return array;
        }
    }
}
