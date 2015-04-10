using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Line : Shape
    {
        private Point[] _points;

        public Line()
        {
            _points = new Point[2]; 
        }

        public void SetPoints(Point[] points)
        {
            this._points = points;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.DrawLine(Pen, _points[0], _points[1]);
        }
    }
}
