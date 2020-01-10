using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Submarine : Ship
    {
        public void CreateSubmarine()
        {
            Submarine submarine = new Submarine();
            submarine.shipName = "Submarine";
            submarine.shipSize = 3;
            submarine.isHit = false;
            submarine.isSunk = false;
        }
    }
}
