using System;
using System.Windows;
using System.Windows.Controls;

namespace PolymorphismExample2
{
    class PolymorphismExample2 : Application
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            PolymorphismExample2 app = new PolymorphismExample2();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            EventWindow window = new EventWindow();
            window.Title = "Polymorphism Example";
            window.Height = 228;
            window.Width = 300;

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
            Button button3 = new Button();
            button3.Content = "Make more transparent";

            StackPanel buttonPanel = new StackPanel();
            buttonPanel.Orientation = Orientation.Horizontal;
            buttonPanel.HorizontalAlignment = 
                System.Windows.HorizontalAlignment.Center;
            buttonPanel.Children.Add(button1);
            buttonPanel.Children.Add(button2);
            buttonPanel.Children.Add(button3);

            mainPanel.Children.Add(calendar);
            mainPanel.Children.Add(buttonPanel);



            button1.Click += OnClick1;
            button2.Click += OnClick2;
            button3.Click += OnClick3;


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
        void OnClick3(object sender, RoutedEventArgs e)
        {
            Panel panel = (Panel) this.Content;
            int childrenCount = panel.Children.Count;
            Console.WriteLine("start");
            foreach (UIElement child in panel.Children)
            {
                MakeMoreTransparent(child);
            }
        }


        void MakeMoreTransparent(UIElement uiElement)
        {
            double opacity = uiElement.Opacity;
            if (opacity > 0.2)
            {
                uiElement.Opacity = opacity - 0.1;
            }

        }
    }
}

