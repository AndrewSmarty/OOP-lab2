using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle()
        {
            _radius = 0;
        }

        public void SetRadius(int radius)
        {
            this._radius = radius;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.FillEllipse(Brush, new System.Drawing.Rectangle(Left, Top, _radius*2, _radius*2));
        }
    }
}
