using System;
using System.Timers;
using Gtk;
using GdkScreen = Gdk.Screen;
using Window = Gtk.Window;

class Program
{ 
    static Label clockLabel = null!;
    static System.Timers.Timer timer = null!;

    static Label timerLabel = null!;
    static System.Timers.Timer timerCountdown = null!;
    static int timerSecondsLeft = 0;

    static Label stopwatchLabel = null!;
    static System.Timers.Timer stopwatchTimer = null!;
    static int stopwatchSeconds = 0;
    static bool stopwatchRunning = false; // corrigido nome da flag

    static System.Timers.Timer clockTimer = null!;
    
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
        window.SetDefaultSize(400, 250); // maior para acomodar botoes e labels
        // window.ModifyBg(StateType.Normal, new Gdk.Color(43, 0, 59));
        window.DeleteEvent += delegate
        {
            clockTimer.Stop();
            timerCountdown?.Stop();
            stopwatchTimer?.Stop();
            Application.Quit();
        };
        Box vbox = new Box(Orientation.Vertical, 10);
        //VBox vbox = new VBox(false, 0);
        window.Add(vbox);
        
        clockLabel = new Label();
        clockLabel.StyleContext.AddClass("clock-label");
        //clockLabel.UseMarkup = true;
        clockLabel.Halign = Align.Center;
        clockLabel.Valign = Align.Center;
        //clockLabel.SetAlignment(0.5f, 0.5f);
        vbox.PackStart(clockLabel, false, false, 0);
        
        var hbox = new Box(Orientation.Horizontal, 20);
        vbox.PackStart(hbox, false, false, 0);
        
       //temporizador
        var timerBox = new Box(Orientation.Vertical, 5);
        var timerButton = new Button("Temporizador"); // corrigido nome da variável
        timerButton.Clicked += OnTimerButtonClicked;  // corrigido nome do handler
        timerLabel = new Label("00:00:00");
        timerLabel.StyleContext.AddClass("small-label");
        timerLabel.Halign = Align.Center;
        var timerResetButton = new Button("Reset");
        timerResetButton.Clicked += (s, e) =>
        {
            timerCountdown?.Stop();
            timerSecondsLeft = 0;
            timerLabel.Text = "00:00:00";
            timerLabel.StyleContext.RemoveClass("timer-done");
        };
        timerBox.PackStart(timerButton, false, false, 0);
        timerBox.PackStart(timerLabel, false, false, 0);
        timerBox.PackStart(timerResetButton, false, false, 0);
        
        // Cronômetro
        var stopwatchBox = new Box(Orientation.Vertical, 5);
        var stopwatchButton = new Button("Cronômetro Iniciar/Parar");
        stopwatchButton.Clicked += OnStopwatchButtonClicked;
        stopwatchLabel = new Label("00:00:00");
        stopwatchLabel.StyleContext.AddClass("small-label");
        stopwatchLabel.Halign = Align.Center;
        var stopwatchResetButton = new Button("Reset");
        stopwatchResetButton.Clicked += (s,e) =>
        {
            stopwatchTimer?.Stop();
            stopwatchRunning = false; // corrigido nome da flag
            stopwatchSeconds = 0;
            stopwatchLabel.Text = "00:00:00";
        };
        stopwatchBox.PackStart(stopwatchButton, false, false, 0);
        stopwatchBox.PackStart(stopwatchLabel, false, false, 0);
        stopwatchBox.PackStart(stopwatchResetButton, false, false, 0);

        hbox.PackStart(timerBox, true, true, 0);
        hbox.PackStart(stopwatchBox, true, true, 0);
        // Timer do relógio principal
        clockTimer = new System.Timers.Timer(1000);
        clockTimer.Elapsed += (s,e) =>
        {
            Application.Invoke(delegate
            {
                clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            });
        };
        clockTimer.Start();

        window.ShowAll();
        Application.Run();
    }

    static void OnTimerButtonClicked(object sender, EventArgs e) // corrigido nome
    {
        var dialog = new Dialog("Definir Temporizador", null, DialogFlags.Modal);
        dialog.SetDefaultSize(250, 100);

        var contentBox = (Box)dialog.ContentArea;
        var prompt = new Label("Digite o tempo em segundos:");
        prompt.ModifyFg(StateType.Normal, new Gdk.Color(255, 215, 0)); // amarelo
        contentBox.PackStart(prompt, false, false, 5);

        var entry = new Entry();
        entry.Text = "60";
        contentBox.PackStart(entry, false, false, 5);

        dialog.AddButton("Cancelar", ResponseType.Cancel);
        dialog.AddButton("Iniciar", ResponseType.Ok);
        dialog.ShowAll();

        var response = (ResponseType)dialog.Run();
        if (response == ResponseType.Ok)
        {
            if (int.TryParse(entry.Text, out int segundos) && segundos > 0)
            {
                timerSecondsLeft = segundos;
                timerLabel.Text = FormatTime(timerSecondsLeft);
                timerLabel.StyleContext.RemoveClass("timer-done");

                if (timerCountdown == null)
                {
                    timerCountdown = new System.Timers.Timer(1000);
                    timerCountdown.Elapsed += TimerCountdown_Elapsed;
                }
                timerCountdown.Start();
            }
        }
        dialog.Destroy();
    }

    static void TimerCountdown_Elapsed(object sender, ElapsedEventArgs e)
    {
        if (timerSecondsLeft > 0)
        {
            timerSecondsLeft--;
            Application.Invoke(delegate
            {
                timerLabel.Text = FormatTime(timerSecondsLeft);
            });
        }
        else
        {
            timerCountdown?.Stop();
            Application.Invoke(delegate
            {
                timerLabel.Text = "00:00:00";
                timerLabel.StyleContext.AddClass("timer-done");
            });
        }
    }

    static void OnStopwatchButtonClicked(object sender, EventArgs e)
    {
        if (stopwatchTimer == null)
        {
            stopwatchTimer = new System.Timers.Timer(1000);
            stopwatchTimer.Elapsed += StopwatchTimer_Elapsed;
        }

        if (!stopwatchRunning)
        {
            stopwatchRunning = true;
            stopwatchTimer.Start();
        }
        else
        {
            stopwatchRunning = false;
            stopwatchTimer.Stop();
        }
    }

    static void StopwatchTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        stopwatchSeconds++;
        Application.Invoke(delegate
        {
            stopwatchLabel.Text = FormatTime(stopwatchSeconds);
        });
    }

    static string FormatTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int remainder = totalSeconds % 3600;
        int mins = remainder / 60;
        int secs = remainder % 60;
        return $"{hours:00}:{mins:00}:{secs:00}";
    }
}
