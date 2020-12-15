using System;
using System.Collections.Generic;
using System.Text;

namespace ShipLists
{
    public class Ship
    {
        public string Id;
        public string ShipName;
        public Owner Owner;

        public Ship(string id, string shipName, Owner owner)
        {
            Id = id;
            ShipName = shipName;
            Owner = owner;
        }
    }
}
