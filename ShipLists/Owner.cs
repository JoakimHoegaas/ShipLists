using System;
using System.Collections.Generic;
using System.Text;

namespace ShipLists
{
    public class Owner
    {
        public string Name;
        public Ship? Ship;
        public List<Ship> ShipCollection = new List<Ship>();

        public Owner(string name, Ship ship)
        {
            Name = name;
            Ship = ship;
        }

        public void AddToShipCollection(Ship ship)
        {
            //if(ship.Owner.Name != Name) etc
            ShipCollection.Add(ship);
        }
            
    }
}
