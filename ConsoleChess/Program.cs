using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Playfield playfield =new  Playfield();
            Player pl = new Player();
            Console.WriteLine("Schachspiel");
            playfield.CreatePlayfield();
            while (true)        //endless loop cause of testing
            { 
                Console.WriteLine();
                pl.AskPlayerToMove();   //Program ask Player to give Coordinates to Move from one Field to another eg. F4 -> F5
                playfield.PlayfieldArray = playfield.ChangePlayfield(playfield.PlayfieldArray, pl.Move()); //overwrites the field, where the player move. Old field is replaced with "  "
                playfield.CreatePlayfield();
                Console.WriteLine();
                //
            }
        }
    }
}
