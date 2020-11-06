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
            while (true) 
            { 
                Console.WriteLine();
                pl.AskPlayerToMove();
                playfield.PlayfieldArray = playfield.ChangePlayfield(playfield.PlayfieldArray, pl.Move());
                playfield.CreatePlayfield();
                Console.WriteLine();
                //
            }
        }
    }
}
