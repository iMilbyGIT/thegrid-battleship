using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Destroyer : Ship
    {
        public void CreateDestroyer()
        {
            Destroyer destroyer = new Destroyer();
            destroyer.shipName = "Destroyer";
            destroyer.shipSize = 2;
            destroyer.isHit = false;
            destroyer.isSunk = false;
        }
    }
}
