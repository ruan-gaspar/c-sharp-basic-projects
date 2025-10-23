// See https://aka.ms/new-console-template for more information
using System;
using System.Timers;
using Gtk;
using GdkScreen = Gdk.Screen;
using Window = Gtk.Window;

class Program
{ 
    static Label clockLabel = null!;
    static System.Timers.Timer timer = null!;

    public static void Main(string[] args)
    {
        Application.Init();
        
        CssProvider cssProvider = new CssProvider();
        cssProvider.LoadFromPath("style.css");
        StyleContext.AddProviderForScreen(GdkScreen.Default, cssProvider, 800);
        
        Window window = new Window("Cyberpunk Timer"); // Título não aparece se houver a função
                                                       // window.Decorated = false
        // window.Decorated = false;
        window.StyleContext.AddClass("clock-label");
        //window.AppPaintable = true;
        window.Visual = window.Screen.RgbaVisual;
        window.SetDefaultSize(400, 180);
        // window.ModifyBg(StateType.Normal, new Gdk.Color(43, 0, 59));
        window.DeleteEvent += delegate
        {
            timer.Stop();
            Application.Quit();
        };
        Box vbox = new Box(Orientation.Vertical, 0);
        //VBox vbox = new VBox(false, 0);
        window.Add(vbox);
        
        clockLabel = new Label();
        clockLabel.StyleContext.AddClass("clock-label");
        clockLabel.UseMarkup = true;
        clockLabel.Halign = Align.Center;
        //clockLabel.SetAlignment(0.5f, 0.5f);
        
        vbox.PackStart(clockLabel, true, true, 0);
        
        timer = new System.Timers.Timer(1000);
        timer.Elapsed += UpdateClock;
        timer.Start();
        
        window.ShowAll();
        Application.Run();
    }

    static void UpdateClock(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Application.Invoke(delegate
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        });
    }
}
