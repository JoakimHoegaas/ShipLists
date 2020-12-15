using System;
using System.Collections.Generic;
using System.Text;

namespace ShipLists
{
    public class ShipYard
    {
        public string Id { get; set; }
        public string ShipName { get; set; }
        public string OwnerName { get; set; }
        public Owner Owner { get; set; }
        public List<Owner> OwnerList = new List<Owner>();

        public ShipYard(string[] csvStream)
        {
            Id = csvStream[0];
            ShipName = csvStream[1];
            OwnerName = csvStream[2];
        }

        public ShipYard(string id, string shipName, string ownerName)
        {
            Id = id;
            ShipName = shipName;
            OwnerName = ownerName;
        }

        public Owner CreateOwner()
        {
            var owner = new Owner(OwnerName, null);
            owner.Ship = CreateShip(owner);
            return owner;
        }

        public Ship CreateShip(Owner owner)
        {
            var ship = new Ship(Id, ShipName, owner);
            return ship;
        }

        public void CheckOwnership(Owner owner, Ship ship)
        {
            foreach(var owner1 in OwnerList)
            {
                if (owner1.Name == ship.Owner.Name)
                {
                    owner.AddToShipCollection(ship);
                    OwnerList.Remove(owner1);
                    owner.AddToShipCollection(owner1.Ship);
                } 
               else OwnerList.Add(owner);
            }
        }
    }
}
