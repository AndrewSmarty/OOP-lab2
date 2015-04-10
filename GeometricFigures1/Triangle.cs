using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Triangle : Shape
    {
        private Point[] _points;

        public Triangle()
        {
            _points = new Point[3];
        }

        public void SetPoints(Point[] points)
        {
            this._points = points;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.FillPolygon(Brush, _points);
        }
    }
}
