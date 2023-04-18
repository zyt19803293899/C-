using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XamlEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DockPanel dockPanel = (DockPanel) this.Content;
            Grid grid = (Grid) dockPanel.Children[0];

            foreach (Object child in grid.Children)
            {
                Rectangle rect = (Rectangle) child;
                SolidColorBrush brush = (SolidColorBrush) rect.Fill;
                Color color = brush.Color;
                color.G = (byte) e.NewValue;
                rect.Fill = new SolidColorBrush(color);
            }

        }

    }
}
