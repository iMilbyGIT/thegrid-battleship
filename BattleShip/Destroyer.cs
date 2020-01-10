using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Destroyer : Ships
    {
        public void CreateDestroyer()
        {
            Destroyer destroyer = new Destroyer();
            destroyer.shipName = "Destroyer";
            destroyer.shipSize = 5;
            destroyer.isHit = false;
            destroyer.isSunk = false;
        }
    }
}
