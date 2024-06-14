
using System;
using Gtk;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Button_Clear(object sender, EventArgs e)
    {
        textview2.Buffer.Text = "";
    }

    protected void Button_Uppe_Case(object sender, EventArgs e)
    {
        textview2.Buffer.Text = textview2.Buffer.Text.ToUpper();
    }

    protected void Button_Lower_Case(object sender, EventArgs e)
    {
        textview2.Buffer.Text = textview2.Buffer.Text.ToLower();
    }

    protected void Button_Save(object sender, EventArgs e)
    {
        StreamWriter sw = new StreamWriter("Test.txt");
        sw.Write(textview2.Buffer.Text);
        textview2.Buffer.Text = "A szöveg mentve!";
        sw.Close();
    }
}
