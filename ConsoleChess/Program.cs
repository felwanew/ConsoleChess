using System;
namespace ConsoleChess
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Playfield playfield = Playfield.GetInstance();
            Player pl1 = new Player("Player1");
            Player pl2 = new Player("Player2");
            int[] KingPosition = new int[4];   //Array to hold position of King (White = first and second value | black = third and fourth value 
            Console.WriteLine("Schachspiel");
            Playfield.playfield.CreatePlayfield();
            while (true)        //endless loop cause of testing and unfinished status of program
            {
                Console.WriteLine("Schachspiel");
                KingPosition = playfield.WhereIsKing(KingPosition);
                for (int i = 0; i >= 0; i++)   //for loop to decide which player have right to move i= -1 when checkmate
                {                
                    Console.WriteLine();
                    if (Playfield.playfield.Round % 2 == 0)
                        Console.WriteLine(pl1.AskPlayerToMove(pl1.Name)); //Program ask Player to give Coordinates to Move from one Field to another eg. F4 -> F5
                    else
                        Console.WriteLine(pl2.AskPlayerToMove(pl2.Name));
                    Playfield.playfield.PlayfieldInternal = Playfield.playfield.ChangePlayfield(Playfield.playfield.PlayfieldInternal, Player.Move(), KingPosition); //overwrites the field, where the player move. Old field is replaced with "  "
                    Playfield.playfield.CreatePlayfield();
                    Console.WriteLine();
                }
            }
        }
    }
}