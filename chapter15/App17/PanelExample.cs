using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class PanelExample : Application
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            PanelExample app = new PanelExample();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            PanelWindow window = new PanelWindow();
            window.Title = "Panel Example";
            window.Height = 228;
            window.Width = 200;

            window.WindowStartupLocation = 
                WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }

    class PanelWindow : Window
    {
        public PanelWindow()
        {
            StackPanel mainPanel = new StackPanel();
            Calendar calendar = new Calendar();
            Button button1 = new Button();
            button1.Content = "Previous Year";
            Button button2 = new Button();
            button2.Content = "Next Year";

            StackPanel buttonPanel = new StackPanel();
            buttonPanel.Orientation = Orientation.Horizontal;
            buttonPanel.HorizontalAlignment = 
                System.Windows.HorizontalAlignment.Center;
            buttonPanel.Children.Add(button1);
            buttonPanel.Children.Add(button2);

            mainPanel.Children.Add(calendar);
            mainPanel.Children.Add(buttonPanel);


            this.Content = mainPanel;
        }
    }
}
