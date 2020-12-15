using System;
using System.IO;
using System.Text;

namespace ShipLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\Users\had00bin\source\repos\ShipLists\ShipLists\Test.csv", Encoding.UTF8);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var columns = line.Split(',');
                var shipYard = new ShipYard(columns);
                var owner = shipYard.CreateOwner();
                var ship = shipYard.CreateShip(owner);
                shipYard.CheckOwnership(owner, ship);
            }
        }
    }
}
