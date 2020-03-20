using System;
using Gtk;
using System.Collections.Generic;
namespace battleship
{
    public enum FieldType
    {
        ship,
        empty
    }
    public enum ColorType
    {
        closed,
        empty,
        ship,
        injured,
        killed,
    }

    public class ColoredButton : Button
    {
        private FieldType state;

        public FieldType getState()
        {
            return state;
        }

        public void PutShip()
        {
            state = FieldType.ship;
            SetColor(ColorType.ship);
        }

        private Dictionary<ColorType, Gdk.Color> colors =
            new Dictionary<ColorType, Gdk.Color>()
            {
            {ColorType.closed,new Gdk.Color(0,153,255)},
            {ColorType.empty,new Gdk.Color(0,153,255)},
            {ColorType.ship,new Gdk.Color(127,127,127)},
            {ColorType.injured,new Gdk.Color(255,0,0)},
            {ColorType.killed,new Gdk.Color(204,51,0)}
            };

        private Dictionary<ColorType, string> colorsTest =
            new Dictionary<ColorType, string>()
            {
                  {ColorType.closed,"?"},
                  {ColorType.empty,""},
                  {ColorType.ship,"+"},
                  {ColorType.injured,"\\"},
                  {ColorType.killed, "@" },
            };

        public void SetColor(ColorType t)
        {
            foreach(StateType i in Enum.GetValues(typeof(StateType)))
              this.ModifyBg(i, colors[t]);

            this.Label = colorsTest[t];


            // Gdk.Pixbuf("/home/dupeljan/Pictures/cursor.png");
            //Image img = new Image("/home/dupeljan/Pictures/cursor.png");
            //this.Image = img;
        }
        public ColoredButton() : base()
        {
            state = FieldType.empty;
        }
    }
}
