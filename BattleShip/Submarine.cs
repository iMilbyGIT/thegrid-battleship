using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Submarine : Ships
    {
        public void CreateSubmarine()
        {
            Submarine submarine = new Submarine();
            submarine.shipName = "Submarine";
            submarine.shipSize = 5;
            submarine.isHit = false;
            submarine.isSunk = false;
        }
    }
}
