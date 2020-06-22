using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Media;
using Point = System.Windows.Point;

namespace PaintPassing
{
    class Ellipse : Shape
    {
        public override void Draw(DrawingContext drawingContext)
        {
            double CenterX;
            double CenterY;
            int x1, y1, x2, y2;
            x1 = (int)StartPoint.X;
            y1 = (int)StartPoint.Y;
            x2 = (int)EndPoint.X;
            y2 = (int)EndPoint.Y;

            CenterX = (x1 + x2) / 2;
            CenterY = (y1 + y2) / 2;

            double RadiusX;
            double RadiusY;

            if (x1 > x2)
            {
                RadiusX = (x1 - x2) / 2;
            }

            else
            {
                RadiusX = (x2 - x1) / 2;
            }

            if (y1 > y2)
            {
                RadiusY = (y1 - y2) / 2;
            }

            else
            {
                RadiusY = (y2 - y1) / 2;
            }

            CenterPoint = new Point(CenterX, CenterY);

            drawingContext.DrawEllipse(null, Outline, CenterPoint, RadiusX, RadiusY);
        }

        private void Point(double CenterX, double CenterY)
        {
            throw new NotImplementedException();
        }
    }
}
