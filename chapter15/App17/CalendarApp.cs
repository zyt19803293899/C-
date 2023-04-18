using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class CalendarApp : Application
    {
        // WPF apps should execute on a STA (single-threaded apartment) thread
        [STAThread]
        static void Main(string[] args)
        {
            CalendarApp app = new CalendarApp();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CalendarWindow window = new CalendarWindow();
            window.Title = "Calendar";
            window.Height = 200;
            window.Width = 200;
            
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }

    class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            Calendar calendar = new Calendar();
            this.Content = calendar;
        }
    }
}