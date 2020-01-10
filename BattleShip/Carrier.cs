using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Carrier : Ship
    {

        public void CreateCarrier()
        {
            Carrier carrier = new Carrier();
            carrier.shipName = "Carrier";
            carrier.shipSize = 5;
            carrier.isHit = false;
            carrier.isSunk = false;
        }
    }
}
