using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class SimpleWPF1    
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            Window window = new Window();
            Label label = new Label();
            label.Content = "The WPF is cool";
            window.Content = label;
            window.Title = "Simple WPF App";
            window.Height = 100;
            window.Width = 300;
            window.WindowStartupLocation = 
                WindowStartupLocation.CenterScreen;
            Application app = new Application();
            app.Run(window);
        }
    }
}