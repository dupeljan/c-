
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox8;

	private global::Gtk.VBox vbox8;

	private global::Gtk.Label label1;

	private global::Gtk.Table tableAllies;

	private global::Gtk.VBox vbox9;

	private global::Gtk.Label label2;

	private global::Gtk.Table tableRival;

	private global::Gtk.VBox vbox10;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.Table tableArrange;

	private global::Gtk.Table table2;

	private global::Gtk.Button buttonArrange;

	private global::Gtk.Button buttonRun;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("ALIES");
		this.vbox8.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.tableAllies = new global::Gtk.Table(((uint)(10)), ((uint)(10)), false);
		this.tableAllies.Name = "tableAllies";
		this.tableAllies.BorderWidth = ((uint)(10));
		this.vbox8.Add(this.tableAllies);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.tableAllies]));
		w2.Position = 1;
		this.hbox8.Add(this.vbox8);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox8]));
		w3.Position = 0;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("RIVALS");
		this.vbox9.Add(this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.tableRival = new global::Gtk.Table(((uint)(10)), ((uint)(10)), false);
		this.tableRival.Name = "tableRival";
		this.tableRival.BorderWidth = ((uint)(10));
		this.vbox9.Add(this.tableRival);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.tableRival]));
		w5.Position = 1;
		this.hbox8.Add(this.vbox9);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox9]));
		w6.Position = 1;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox10.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.GtkScrolledWindow]));
		w8.Position = 0;
		// Container child vbox10.Gtk.Box+BoxChild
		this.tableArrange = new global::Gtk.Table(((uint)(1)), ((uint)(4)), false);
		this.tableArrange.Name = "tableArrange";
		this.tableArrange.RowSpacing = ((uint)(6));
		this.tableArrange.ColumnSpacing = ((uint)(6));
		this.vbox10.Add(this.tableArrange);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.tableArrange]));
		w9.Position = 1;
		// Container child vbox10.Gtk.Box+BoxChild
		this.table2 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.buttonArrange = new global::Gtk.Button();
		this.buttonArrange.CanFocus = true;
		this.buttonArrange.Name = "buttonArrange";
		this.buttonArrange.UseUnderline = true;
		this.buttonArrange.Label = global::Mono.Unix.Catalog.GetString("Arrange");
		this.table2.Add(this.buttonArrange);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonArrange]));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.buttonRun = new global::Gtk.Button();
		this.buttonRun.CanFocus = true;
		this.buttonRun.Name = "buttonRun";
		this.buttonRun.UseUnderline = true;
		this.buttonRun.Label = global::Mono.Unix.Catalog.GetString("Run");
		this.table2.Add(this.buttonRun);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.buttonRun]));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox10.Add(this.table2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.table2]));
		w12.Position = 2;
		this.hbox8.Add(this.vbox10);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox10]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		this.Add(this.hbox8);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1110;
		this.DefaultHeight = 488;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonRun.Clicked += new global::System.EventHandler(this.OnButtonRunClicked);
		this.buttonArrange.Clicked += new global::System.EventHandler(this.OnButtonArrangeClicked);
	}
}
