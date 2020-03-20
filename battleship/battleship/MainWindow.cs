using System;
using System.Collections.Generic;
using battleship;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    public struct Coords
    {
        public int X;
        public int Y;
        public void setXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    private const int rows = 10;
    private const int cols = 10;

    private List<Ship> ShipConstrains =
        new List <Ship>()
        {
            new Ship("Большой коралик",   4,1),
            new Ship("Средний кораблик",  3,2),
            new Ship("Маленький кораблик",2,3),
            new Ship("Крохотный кораблик",1,4),

        };

  
    private enum States
    {
        arrangement,
        ready,
        battle
    }


    private bool CheckField(List<List<ColoredButton>> field,Ship ship,int rot,Coords c)
    {
        bool res = true;
        for (int i = 0; i < ship.len && true; i++)
        {
            res = field[c.X][c.Y].getState() == FieldType.empty;
            c = SetCoord(c, rot);
        }

        return res;

    }
    private Coords SetCoord(Coords inp, int rot)
    {
        if (rot != 0)
            inp.X++;
        else
            inp.Y++;
        return inp;
    }
    private void Arrange(List<List<ColoredButton>> field)
    {
        Random random = new Random();
        foreach (Ship t in ShipConstrains)
            for (int i = 0; i < t.count; i++)
            {
                int rot = random.Next() % 2;
                Coords c = new Coords();
                c.setXY(random.Next() % cols, random.Next() % rows);
                while ( !CheckField(field,t,rot,c))
                {
                    // Change pos
                    c.X = random.Next() % cols;
                    c.Y = random.Next() % rows;
                }
                // Put ship
                for (int j = 0; j < t.len; j++)
                {
                    field[c.X][c.Y].PutShip();
                    c = SetCoord(c, rot);
                }
            }
    }
    private void Init()
    {

        // Init buttons
        bAllies = new List<List<ColoredButton>>();
        bRivals = new List<List<ColoredButton>>();
        for (int i = 0; i < rows; i++)
        {
            bAllies.Add(new List<ColoredButton>());
            bRivals.Add(new List<ColoredButton>());
            for (int j = 0; j < cols; j++)
            {
                ColoredButton ba = new ColoredButton();
                ba.Name = "buttona" + i.ToString() + j.ToString();
                ba.SetColor(ColorType.empty);
                bAllies[i].Add(ba);
                this.tableAllies.Attach(ba, Convert.ToUInt32(i), Convert.ToUInt32(i) + 1,
                    Convert.ToUInt32(j), Convert.ToUInt32(j) + 1);
                ba.Clicked += OnButtonAlliesClicked;
                ba.Show();

                ColoredButton br = new ColoredButton();
                br.Name = "buttonr" + i.ToString() + j.ToString();
                br.SetColor(ColorType.closed);
                bRivals[i].Add(br);
                this.tableRival.Attach(br, Convert.ToUInt32(i), Convert.ToUInt32(i) + 1,
                 Convert.ToUInt32(j), Convert.ToUInt32(j) + 1);
                br.Clicked += OnButtonRivalsClicked;
                br.Show();
            }

        }
    }
    private States state;
    List<List<ColoredButton>> bRivals, bAllies;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        state = States.arrangement;
        Init();  
       
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonAlliesClicked(object sender, EventArgs e)
    {
        if (state == States.battle)
        {

        }
    }

    protected void OnButtonRivalsClicked(object sender, EventArgs e)
    {

    }

    protected void OnButtonArrangeClicked(object sender, EventArgs e)
    {
        Arrange(bAllies);
    }

    protected void OnButtonRunClicked(object sender, EventArgs e)
    {
        Arrange(bRivals);
    }
}
