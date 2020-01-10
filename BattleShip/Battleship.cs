using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Battleship : Ships
    {
        public void CreateBattleShip()
        {
            Battleship battleship = new Battleship();
            battleship.shipName = "BattleShip";
            battleship.shipSize = 5;
            battleship.isHit = false;
            battleship.isSunk = false;
        }
    }
}
