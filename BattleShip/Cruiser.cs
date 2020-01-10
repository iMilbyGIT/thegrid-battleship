using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Cruiser : Ship
    {
        public void CreateCruiser()
        {
            Cruiser cruiser = new Cruiser();
            cruiser.shipName = "Cruiser";
            cruiser.shipSize = 3;
            cruiser.isHit = false;
            cruiser.isSunk = false;
        }
    }
}
