using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    //Carrier(occupies 5 spaces), Battleship(4), Cruiser(3), Submarine(3), and Destroyer(2)
    
    public class Ship
    {
        public string shipName;
        public int shipSize;
        public bool isHit;
        public bool isSunk;
        public Cruiser cruiser;
        public Battleship battleship;
        public Carrier carrier;
        public Submarine submarine;
        public Destroyer destroyer;

        public void ShipHit()
        {
            isHit = true;
        }
        public void MissHit()
        {
            isHit = false;
        }
        public void ShipSunk()
        {
            isSunk = true;
        }
    }
}
//Carrier(occupies 5 spaces), Battleship(4), Cruiser(3), Submarine(3), and Destroyer(2)