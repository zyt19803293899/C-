using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlExample2
{
    class CodeOnly : Application
    {
        // WPF apps should execute on a STA thread
        [STAThread]
        static void Main(string[] args)
        {
            CodeOnly app = new CodeOnly();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Window window = new Window();
            window.Title = "CodeOnly Equivalent";
            window.Height = 350;
            window.Width = 525;

            DockPanel dockPanel = new DockPanel();
            dockPanel.LastChildFill = true;

            Label topElement = new Label();
            topElement.Content = "Top";
            DockPanel.SetDock(topElement, Dock.Top);
            topElement.Foreground = 
                new SolidColorBrush(Colors.Green);
            topElement.Background = 
                new SolidColorBrush(Colors.Bisque);
            topElement.Height = 100;
            topElement.HorizontalContentAlignment = 
                HorizontalAlignment.Center;
            
            Label leftElement = new Label();
            leftElement.Content = "Left";
            leftElement.Foreground = 
                new SolidColorBrush(Colors.Red);
            leftElement.Background = 
                new SolidColorBrush(Colors.Beige);
            leftElement.Width = 50;
            leftElement.VerticalContentAlignment = 
                VerticalAlignment.Center;
            DockPanel.SetDock(leftElement, Dock.Left);

            TextBox rightElement = new TextBox();
            rightElement.Text = "Right";
            rightElement.Foreground = 
                new SolidColorBrush(Colors.Blue);
            rightElement.Background = 
                new SolidColorBrush(Colors.AliceBlue);
            DockPanel.SetDock(rightElement, Dock.Right);

            dockPanel.Children.Add(topElement);
            dockPanel.Children.Add(leftElement);
            dockPanel.Children.Add(rightElement);

            window.Content = dockPanel;
            window.Show();
        }
    }
}