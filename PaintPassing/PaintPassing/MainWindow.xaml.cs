using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintPassing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>]
    public partial class MainWindow : Window
    {
        enum Func
        {
            Line,
            Rectangle,
            Ellipse,
            Pencil
        }

        Shape Shape;
        List<Shape> Shapes = new List<Shape>();
        Func func;
        public MainWindow()
        {
            InitializeComponent();
            Canv.Children.Add(visualHost);

            visualHost.Redraw(Shapes);

            func = Func.Line;
        }

        public VisualHost visualHost = new VisualHost();

        private void Canv_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed) return;
            if (func == Func.Pencil)
            {
                Shape.EndPoint = e.GetPosition(Canv);
                var dv = new DrawingVisual();
                using (var dc = dv.RenderOpen())
                {
                    Shape.Draw(dc);
                }
                if (Shape.StartPoint != Shape.EndPoint)
                {
                    Shapes.Add(Shape.Clone());
                }
                visualHost.Redraw(Shapes);
                Shape.StartPoint = Shape.EndPoint;
            }
            else
            {
                Shape.EndPoint = e.GetPosition(Canv);
                var dv = new DrawingVisual();
                using (var dc = dv.RenderOpen())
                {
                    Shape.Draw(dc);
                }
                visualHost.Redraw(Shapes);
                visualHost.AddChild(dv);
            }
        }

        private void Canv_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed) return;
            Shape = func switch
            {
                Func.Line => new Line() { Outline = new Pen(Brushes.Black, 1) },
                Func.Rectangle => new Rectangle() { Outline = new Pen(Brushes.Black, 1) },
                Func.Ellipse => new Ellipse() { Outline = new Pen(Brushes.Black, 1) },
                Func.Pencil => new Line() { Outline = new Pen(Brushes.Black, 1) },
                _ => throw new Exception()
            };
            Shape.StartPoint = e.GetPosition(Canv);
        }

        private void Canv_MouseUp(object sender, MouseButtonEventArgs e)
        {

            Shapes.Add(Shape.Clone());
            visualHost.Redraw(Shapes);
        }
        private void ButtonLine_Click(object sender, RoutedEventArgs e)
        {
            func = Func.Line;
        }

        private void ButtonEllipse_Click(object sender, RoutedEventArgs e)
        {
            func = Func.Ellipse;
        }

        private void ButtonRectangle_Click(object sender, RoutedEventArgs e)
        {
            func = Func.Rectangle;
        }
        private void ButtonPencil_Click(object sender, RoutedEventArgs e)
        {
            func = Func.Pencil;
        }
    }
}
