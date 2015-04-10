using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Ellipse : Circle
    {
        private int _width;
        private int _height;

        public Ellipse()
        {
            _width = 0;
            _height = 0;
        }

        public void SetDimensions(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.FillEllipse(Brush, new System.Drawing.Rectangle(Left, Top, _width, _height));
        }
    }
}
