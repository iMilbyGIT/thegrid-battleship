using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    //Carrier(occupies 5 spaces), Battleship(4), Cruiser(3), Submarine(3), and Destroyer(2)
    public class Ships
    {
        Ships ship;
        public string shipName;
        public int shipSize;
        public bool isHit;
        public bool isSunk;
        
        public void ShipHit()
        {
            isHit = true;
        }
        public void ShipSunk()
        {
            isSunk = true;
        }

        //List<Ships> ships = new List<Ships>()
        //{
        //    ships.Add(CreateCarrier);
        //};

        public void CreateCarrier()
        {
            Ships carrier = new Ships();
            carrier.shipName = "Carrier";
            carrier.shipSize = 5;
            carrier.isHit = false;
            carrier.isSunk = false;
        }
        public void CreateBattleShip()
        {
            Ships battleship = new Ships();
            battleship.shipName = "BattleShip";
            battleship.shipSize = 5;
            battleship.isHit = false;
            battleship.isSunk = false;
        }
        public void CreateCruiser()
        {
            Ships cruiser = new Ships();
            cruiser.shipName = "Cruiser";
            cruiser.shipSize = 5;
            cruiser.isHit = false;
            cruiser.isSunk = false;
        }
        public void CreateSubmarine()
        {
            Ships submarine = new Ships();
            submarine.shipName = "Submarine";
            submarine.shipSize = 5;
            submarine.isHit = false;
            submarine.isSunk = false;
        }
        public void CreateDestroyer()
        {
            Ships destroyer = new Ships();
            destroyer.shipName = "Destroyer";
            destroyer.shipSize = 5;
            destroyer.isHit = false;
            destroyer.isSunk = false;
        }
    }
}
//Carrier(occupies 5 spaces), Battleship(4), Cruiser(3), Submarine(3), and Destroyer(2)