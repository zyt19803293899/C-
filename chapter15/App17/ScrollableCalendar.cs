using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class ScrollableCalendarApp : Application
    {
        // WPF apps should execute on a STA (single-threaded apartment) thread
        [STAThread]
        static void Main(string[] args)
        {
            ScrollableCalendarApp app = new ScrollableCalendarApp();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ScrollableCalendarWindow window = new ScrollableCalendarWindow();
            window.Title = "Scrollable Calendar";
            window.Height = 250;
            window.Width = 200;

            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }

    class ScrollableCalendarWindow : Window
    {
        public ScrollableCalendarWindow()
        {
            Calendar calendar = new Calendar();
            this.Content = calendar;
        }
    }
}
