using System;
using System.Collections.Generic;
using System.Text;

namespace PaintPassing
{
    public class Line : Shape
    {
        public override void Draw(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawLine(Outline, StartPoint, EndPoint);
        }
    }
}
