using System;
using System.Windows;
using System.Windows.Media;

namespace PaintPassing
{
    public abstract class Shape
    {
        protected Shape()
        {
            StartPoint = new Point(-1, -1);
            EndPoint = new Point(-1, -1);
            Outline = new Pen(Brushes.Black, 1);
        }

        public virtual Shape Clone() => (Shape)MemberwiseClone();

        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public Pen Outline { get; set; }

        public Point CenterPoint { get; set; }

        public Point CoordinatesPoint { get; set; }

        public abstract void Draw(DrawingContext drawingContext);
    }
}