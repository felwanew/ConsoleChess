using System;

namespace ConsoleChess
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Player pl1 = new Player("Player1", true);
            Player pl2 = new Player("Player2", false);
            Player currentPlayer = pl1;
            Console.WriteLine("Schachspiel");
            Playfield.ShowPlayfield();
            while (true)        //endless loop cause of testing and unfinished status of program
            {
                Console.WriteLine();
                Console.WriteLine(AskPlayerToMove(currentPlayer)); //Program ask Player to give Coordinates to Move from one Field to another eg. F4 -> F5
                if (Playfield.ChangePlayfield(Move(), currentPlayer)) //overwrites the field, where the player move. Old field is replaced with "  "
                {
                    currentPlayer = currentPlayer == pl1 ? pl2 : pl1;
                }
                else
                {
                    Console.WriteLine("Zug ungültig");
                }
                Playfield.ShowPlayfield();
                Console.WriteLine();
            }
        }
        public static string AskPlayerToMove(Player Player)
        {
            return Player.FullName + " du bist am Zug";
        }
        public static string[] Move()
        {
            Console.Write("Von: ");
            string movefrom = Console.ReadLine();
            Console.Write("Nach: ");
            string moveto = Console.ReadLine();
            string[] array = new string[] { movefrom.Substring(0, 1), movefrom.Substring(1, 1), moveto.Substring(0, 1), moveto.Substring(1, 1) }; //fängt zu lange Abfragen ab z.B. F321ve = F3
            Console.WriteLine(array[0] + " " + array[1] + " " + array[2] + " " + array[3]);
            return array;
        }
    }
}
