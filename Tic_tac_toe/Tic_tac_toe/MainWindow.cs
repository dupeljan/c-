using System;
using Gtk;
using System.Collections.Generic;
using System.Linq;
public partial class MainWindow : Gtk.Window
{
    private HashSet<int> xSet,oSet;
    private bool state;
    private int xWin, oWin;
    private List<Button> buttonList;
    public enum  Mode { pvp,xBot,oBot};
    public enum Player { human,ai};
    public struct Score
    {
        public int  pos;
        public int score;
        public Score(int pos,int score)
        {
            this.pos = pos;
            this.score = score;
        }
    }
    private Mode mode;
   
     private int makeStep()
    {
        HashSet<int> avaliable = new HashSet<int>();
        for (int i = 1; i < 10; i++)
            if (!xSet.Contains(i) && !oSet.Contains(i))
                avaliable.Add(i);
        if (avaliable.Count == 9)
            return 1;
        // random best choise
        List<Score> moves = new List<Score>();
        int max_ = -10;
        foreach(int x in avaliable)
        {
            HashSet<int> ncxSet = new HashSet<int>(xSet);
            HashSet<int> ncoSet = new HashSet<int>(oSet);
            HashSet<int> navlbl = new HashSet<int>(avaliable);
            if (mode == Mode.xBot)
                ncxSet.Add(x);
            else
                ncoSet.Add(x);
            navlbl.Remove(x);
            Score cur = new Score(x, MinMax(ncxSet, ncoSet, navlbl, Player.human).score);
            if (cur.score > max_)
                max_ = cur.score; 
            moves.Add(cur);
        }
        List<Score> bestChoice = moves.Where(x => x.score == max_).ToList(); ;
        Random rnd = new Random();
        int r = rnd.Next(bestChoice.Count);
        return bestChoice[r].pos;
        //return MinMax(xSet,oSet,avaliable,Player.ai).pos;
    }
    private Score MinMax(HashSet<int>cxSet,HashSet<int>coSet,HashSet<int>avlbl,Player p)
    {
        // end of recursion
        if (win(cxSet))
        {
            if (mode == Mode.xBot)
                return new Score(-1, 10);
            if (mode == Mode.oBot)
                return new Score(-1, -10);
        }
        if (win(coSet))
        {
            if (mode == Mode.xBot)
                return new Score(-1, -10);
            if (mode == Mode.oBot)
                return new Score(-1, 10);
        }
        if (avlbl.Count == 0)
            return new Score(-1, 0);


        // make steps forward
        List<Score> moves = new List<Score>();
        Player np;
        if (p == Player.ai)
            np = Player.human;
        else
            np = Player.ai;

        foreach ( int i in avlbl)
        {
            HashSet<int> ncxSet = new HashSet<int>(cxSet);
            HashSet<int> ncoSet = new HashSet<int>(coSet);
            HashSet<int> navlbl = new HashSet<int>(avlbl);
  
            if ((p == Player.ai && mode == Mode.xBot)||
                (p == Player.human && mode == Mode.oBot))
                ncxSet.Add(i);
            else
                ncoSet.Add(i);

            navlbl.Remove(i);

            moves.Add (new Score(i,MinMax(ncxSet, ncoSet, navlbl, np).score));

        }
        // Choose best step
        Func<Score, Score, bool> cmp; 

        if(p == Player.ai)
            cmp = (a,b) =>
                 a.score < b.score;
        else
            cmp = (a,b) =>
               a.score > b.score;

        Score res = moves[0];

        foreach (Score s in moves)
            if (cmp(res, s))            
                res = s;

        return res;
    }

    private void blockAll(bool val)
    {
        foreach (Button b in this.table1.AllChildren)
        {
            b.Sensitive = !val;
        }
    }

    private void initGame()
    {
        xSet = new HashSet<int>();
        oSet = new HashSet<int>();
        state = false;
        blockAll(false);
        foreach (Button b in this.table1.AllChildren)
        {
            b.Label = "";
        }
        this.textview.Buffer.Text = "Tick Tack Toe game" +
            "\nX : " + xWin.ToString() + "\nO : " + oWin.ToString();
        logic();
    }
    private bool win(HashSet<int> col)
    {
        if (col.Count < 3)
            return false;

        bool contain(HashSet<int> c,int[] v)
        {
            return c.Contains(v[0]) && c.Contains(v[1]) && c.Contains(v[2]);
        }

        // Conduct rows and cols
        for (int x = 0; x < 3; x++)
            if (contain(col, new int[3] { 1 + 3 * x, 2 + 3 * x, 3 + 3 * x }) ||
                contain(col, new int[3] { x + 1, x + 4, x + 7 }))
                return true;
        // conduct diag
        if (contain(col, new int[3] { 1, 5, 9 }) || 
            contain(col, new int[3] { 3, 5, 7 }))
            return true;
        return false;
    }

    private void logic()
    {
        if (win(xSet))
        {
            xWin += 1;
            this.textview.Buffer.Text += "\nX WIN!";
            blockAll(true);
        }else if (win(oSet))
        {
            oWin += 1;
            this.textview.Buffer.Text += "\nO WIN!";
            blockAll(true);
        }
        else if (xSet.Count + oSet.Count == 9)
        {
            this.textview.Buffer.Text += "\nDRAFT!";
        }
        else
        if ((mode == Mode.xBot && !state )||
            (mode == Mode.oBot && state))
        {
            //System.Threading.Thread.Sleep(2000);
            int step = makeStep();
            OnButtonClicked(buttonList[step-1], null);
        }
    }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        xWin = oWin = 0;
        mode = Mode.pvp;
        buttonList = new List<Button>();
        Build();
        foreach (Button b in this.table1.AllChildren) {
            buttonList.Add(b);
        }
        buttonList.Reverse();

        initGame();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonClicked(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        if ( b.Label == "")
        {
            state = !state;
            if (state)
            {
                b.Label = "X";
                xSet.Add(Convert.ToInt32(Char.ToString(b.Name[b.Name.Length - 1])));
            }
            else
            {
                b.Label = "O";
                oSet.Add(Convert.ToInt32(Char.ToString(b.Name[b.Name.Length - 1])));
            }
            logic();
        }
    }

    protected void OnButtonTryAgainClicked(object sender, EventArgs e)
    {
        initGame();
    }

    protected void OnButtonModeClicked(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        if (b.Name == "buttonPVP")
            mode = Mode.pvp;
        else if (b.Name == "buttonXBot")
            mode = Mode.xBot;
        else if (b.Name == "buttonOBot")
            mode = Mode.oBot;
        logic();
    }
}
