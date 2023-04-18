using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class SimpleWpf2 : Application
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            SimpleWpf2 app = new SimpleWpf2();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Calendar calendar = new Calendar();
            Window window = new Window();
            window.Title = "WPF 2";
            window.Height = 205;
            window.Width = 200;
            window.Content = calendar;

            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}