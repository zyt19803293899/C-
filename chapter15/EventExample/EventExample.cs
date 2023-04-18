using System;
using System.Windows;
using System.Windows.Controls;

namespace App17
{
    class EventExample : Application
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            EventExample app = new EventExample();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            EventWindow window = new EventWindow();
            window.Title = "Event Example";
            window.Height = 228;
            window.Width = 200;

            window.WindowStartupLocation = 
                WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }

    class EventWindow : Window
    {
        Calendar calendar;
        public EventWindow()
        {
            StackPanel mainPanel = new StackPanel();
            calendar = new Calendar();
            Button button1 = new Button();
            button1.Content = "Highlight";
            Button button2 = new Button();
            button2.Content = "No Highlight";

            StackPanel buttonPanel = new StackPanel();
            buttonPanel.Orientation = Orientation.Horizontal;
            buttonPanel.HorizontalAlignment = 
                System.Windows.HorizontalAlignment.Center;
            buttonPanel.Children.Add(button1);
            buttonPanel.Children.Add(button2);

            mainPanel.Children.Add(calendar);
            mainPanel.Children.Add(buttonPanel);



            button1.Click += OnClick1;
            button2.Click += OnClick2;


            this.Content = mainPanel;
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            calendar.IsTodayHighlighted = true;
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            calendar.IsTodayHighlighted = false;
        }
    }
}
