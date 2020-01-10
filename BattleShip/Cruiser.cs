using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Cruiser : Ships
    {
        public void CreateCruiser()
        {
            Cruiser cruiser = new Cruiser();
            cruiser.shipName = "Cruiser";
            cruiser.shipSize = 5;
            cruiser.isHit = false;
            cruiser.isSunk = false;
        }
    }
}
