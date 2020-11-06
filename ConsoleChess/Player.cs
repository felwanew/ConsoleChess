using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Player
    {
        public string AskPlayerToMove()
        {
            return " du bist am Zug";
        }
        public string[] Move()
        {
            string movefrom = Console.ReadLine();
            string moveto = Console.ReadLine();
            string[] array = new string[] { movefrom.Substring(0, 1), movefrom.Substring(1, 1), moveto.Substring(0, 1), moveto.Substring(1, 1) }; //fängt zu lange Abfragen ab z.B. F321ve = F3
            Console.WriteLine(array[0]+ " " + array[1] + " " + array[2] + " " + array[3]);
            return array;
        }
        public void WhichPlayerTurn()
        {

        }
    }
}
