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
        clockLabel = new Label();
        clockLabel.SetAlignment(0.5f, 0.5f);
        window.Add(clockLabel);

        timer = new Timer(1000);
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
