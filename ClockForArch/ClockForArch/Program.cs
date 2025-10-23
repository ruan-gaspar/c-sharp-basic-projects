// See https://aka.ms/new-console-template for more information
using System;
using Gtk;
using System.Timers;
using Timer = System.Timers.Timer;

class Program
{ 
    static Label clockLabel;
    static System.Timers.Timer timer;

    public static void Main(string[] args)
    {
        Application.Init();
        
        Window window = new Window("Relógio GTK#");
        window.SetDefaultSize(250, 100);
        window.DeleteEvent += delegate
        {
            timer.Stop();
            Application.Quit();
        };

        VBox vbox = new VBox(false, 0);
        window.Add(vbox);
        
        
        
        clockLabel = new Label();
        clockLabel.UseMarkup = true;
        clockLabel.SetAlignment(0.5f, 0.5f);
        
        vbox.PackStart(clockLabel, true, true, 0);
        
        timer = new System.Timers.Timer(1000);
        timer.Elapsed += UpdateClock;
        timer.Start();
        
        window.ShowAll();
        Application.Run();
    }

    static void UpdateClock(object sender, ElapsedEventArgs e)
    {
        Application.Invoke(delegate
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        });
    }
}
