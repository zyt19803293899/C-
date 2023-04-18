using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class SimpleWinApp : Application
    {
        // WPF apps should execute on a STA (single-threaded apartment) thread
        [STAThread]
        static void Main(string[] args)
        {
            SimpleWinApp app = new SimpleWinApp();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Window window = new Window();
            window.Title = "Simple WinApp";
            window.Height = 300;
            window.Width = 300;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}