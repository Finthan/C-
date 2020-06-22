using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PaintPassing
{
    public class Rectangle : Shape
    {
        public override void Draw(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(null, Outline, new Rect(StartPoint, EndPoint));
        }
    }
}
