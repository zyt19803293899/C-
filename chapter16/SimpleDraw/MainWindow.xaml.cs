using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace SimpleDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum ShapeType 
        {
            Line, Oval, Rectangle
        }
        private Point startPoint;
        private Point endPoint;
        private ShapeType shapeType = ShapeType.Line;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(this);
        }

        private void canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            endPoint = e.GetPosition(this);
            IShape shape = null;
            if (shapeType == ShapeType.Line)
            {
                shape = new SimpleLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }
            else if (shapeType == ShapeType.Oval)
            {
                shape = new SimpleOval(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }
            else if (shapeType == ShapeType.Rectangle)
            {
                shape = new SimpleRectangle(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            }

            if (shape != null)
            {
                Grid grid = (Grid)this.FindName("buttonGrid");
                shape.Draw(grid);
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            shapeType = ShapeType.Line;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            shapeType = ShapeType.Oval;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            shapeType = ShapeType.Rectangle;
        }
    }


    interface IShape
    {
        void Draw(Grid myGrid);
    }

    public class SimpleLine : IShape
    {
        double x1, y1, x2, y2;

        public SimpleLine(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw(Grid grid)
        {
            Line windowLine = new Line();
            windowLine.X1 = x1;
            windowLine.Y1 = y1;
            windowLine.X2 = x2;
            windowLine.Y2 = y2;
            windowLine.Stroke = System.Windows.Media.Brushes.Magenta;
            windowLine.StrokeThickness = 2;
            grid.Children.Add(windowLine);
        }
    }

    public class SimpleOval : IShape
    {
        double x1, y1, x2, y2;

        public SimpleOval(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw(Grid grid)
        {
            double x, y;
            Ellipse oval = new Ellipse();
            Thickness margin;
            if (x1 < x2)
            {
                x = x1;
            }
            else
            {
                x = x2;
            }
            if (y1 < y2)
            {
                y = y1;
            }
            else
            {
                y = y2;
            }
            margin = new Thickness(x, y, 0, 0);
            oval.Margin = margin;
            oval.HorizontalAlignment = HorizontalAlignment.Left;
            oval.VerticalAlignment = VerticalAlignment.Top;
            oval.Stroke = System.Windows.Media.Brushes.LimeGreen;
            oval.Width = Math.Abs(x2 - x1);
            oval.Height = Math.Abs(y2 - y1);
            Canvas.SetLeft(oval, x);
            Canvas.SetTop(oval, y);
            oval.StrokeThickness = 2;
            grid.Children.Add(oval);
        }
    }

    public class SimpleRectangle : IShape
    {
        double x1, y1, x2, y2;

        public SimpleRectangle(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw(Grid grid)
        {
            double x, y;
            Rectangle rect = new Rectangle();
            if (x1 < x2)
            {
                x = x1;
            }
            else
            {
                x = x2;
            }
            if (y1 < y2)
            {
                y = y1;
            }
            else
            {
                y = y2;
            }
            Thickness margin = new Thickness(x, y, 0, 0);
            rect.Margin = margin;
            rect.HorizontalAlignment = HorizontalAlignment.Left;
            rect.VerticalAlignment = VerticalAlignment.Top;
            rect.Stroke = System.Windows.Media.Brushes.Red;
            rect.Width = Math.Abs(x2 - x1);
            rect.Height = Math.Abs(y2 - y1);
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            rect.StrokeThickness = 2;
            grid.Children.Add(rect);
        }
    }

}
