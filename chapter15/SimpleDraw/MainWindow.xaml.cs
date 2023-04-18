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

namespace SimpleDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Point startPoint;
        private System.Windows.Point endPoint;
        private int drawType = 0;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(this);
            Console.WriteLine("mouse down " + startPoint.X + ", " + startPoint.Y);
        }

        private void canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            endPoint = e.GetPosition(this);
            Console.WriteLine("mouse up " + endPoint.X + ", " + endPoint.Y);
            DrawShape shape = null;
            if (drawType == 0)
            {
                shape = new DrawLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }
            else if (drawType == 1)
            {
                shape = new DrawOval(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }
            else if (drawType == 2)
            {
                shape = new DrawRectangle(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }

            if (shape != null)
            {
                Grid grid = (Grid)this.FindName("idgrid");
                shape.draw(grid);
            }
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            //endPoint = e.GetPosition(this);
            //Console.WriteLine("mouse move " + endPoint.X + ", " + endPoint.Y);
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            drawType = 0;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            drawType = 1;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            drawType = 2;
        }
    }


    interface DrawShape {
        void draw(Grid myGrid);
    }

    public class DrawLine : DrawShape
    {
        double x1, y1, x2, y2;

        public DrawLine(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void draw(Grid grid)
        {
            Line line = new Line();
            line.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;
            line.StrokeThickness = 2;
            grid.Children.Add(line);
        }
    }

    public class DrawOval : DrawShape
    {
        double x1, y1, x2, y2;

        public DrawOval(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void draw(Grid grid)
        {
            Ellipse oval = new Ellipse();
            Thickness margin = new Thickness(x1, y1, 0, 0);
            oval.Margin = margin;
            oval.HorizontalAlignment = HorizontalAlignment.Left;
            oval.VerticalAlignment = VerticalAlignment.Top;
            oval.Stroke = System.Windows.Media.Brushes.LimeGreen;
            oval.Width = Math.Abs(x2-x1);
            oval.Height = Math.Abs(y2-y1);
            Canvas.SetLeft(oval, x1);
            Canvas.SetLeft(oval, y1);
            oval.StrokeThickness = 2;
            grid.Children.Add(oval);
        }
    }

    public class DrawRectangle : DrawShape
    {
        double x1, y1, x2, y2;

        public DrawRectangle(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void draw(Grid grid)
        {
            Rectangle rect = new Rectangle();
            Thickness margin = new Thickness(x1, y1, 0, 0);
            rect.Margin = margin;
            rect.HorizontalAlignment = HorizontalAlignment.Left;
            rect.VerticalAlignment = VerticalAlignment.Top;
            rect.Stroke = System.Windows.Media.Brushes.Red;
            rect.Width = Math.Abs(x2-x1);
            rect.Height = Math.Abs(y2-y1);
            Canvas.SetLeft(rect, 0);
            Canvas.SetTop(rect, 0);
            rect.StrokeThickness = 2;
            grid.Children.Add(rect);
        }
    }

}
