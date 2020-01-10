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
        Ship carrier = new Ship("Carrier", 5, false, false);
        public Ship(string shipName, int shipSize, bool isHit, bool isSunk)
        {
            this.shipName = shipName;
            this.shipSize = shipSize;
            this.isHit = isHit;
            this.isSunk = isSunk;
        }
        public void TakeDamage()
        {
            if (isHit == true)
            {
                shipSize--;
            }
            if (shipSize == 0)
            {
                ShipSunk();
            }
        }
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