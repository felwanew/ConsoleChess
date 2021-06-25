using System;

namespace ConsoleChess
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Player pl1 = new Player("Player1");
            Player pl2 = new Player("Player2");
            Console.WriteLine("Schachspiel");
            Playfield.CreatePlayfield();
            while (true)        //endless loop cause of testing and unfinished status of program
            { 
                for(int i = 0; i >= 0; i++)   //for loop to decide wich player have right to move i=-1 when checkmate
                {                
                    Console.WriteLine();
                    if (i % 2 == 0)
                        Console.WriteLine(pl1.AskPlayerToMove(pl1.Name)); //Program ask Player to give Coordinates to Move from one Field to another eg. F4 -> F5
                    else
                        Console.WriteLine(pl2.AskPlayerToMove(pl2.Name));   
                    Playfield.PlayfieldArray = Playfield.ChangePlayfield(Playfield.PlayfieldArray, Player.Move()); //overwrites the field, where the player move. Old field is replaced with "  "
                    Playfield.CreatePlayfield();
                    Console.WriteLine();
                }
            }
        }
    }
}
