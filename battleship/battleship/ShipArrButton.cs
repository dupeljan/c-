using System;
using Gtk;

namespace battleship
{
    public struct Ship
    {
        public String cap;
        public int len;
        public int count;

        public Ship(string cap, int len, int count)
        {
            this.cap = cap;
            this.len = len;
            this.count = count;
        }
    }


    public class ShipArrButton: Button
    {
        public Ship ship;
        public ShipArrButton(Ship ship) : base()
        {
            this.ship = ship;
        }
    }
}
