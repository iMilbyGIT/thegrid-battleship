using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 5 ships are: Carrier(occupies 5 spaces), Battleship(4), Cruiser(3), Submarine(3), and Destroyer(2). Please press any button to continue.");
            Console.ReadLine();
            TheGrid.Run();
        }
    }
}
