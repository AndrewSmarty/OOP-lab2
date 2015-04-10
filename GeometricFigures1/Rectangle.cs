using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Rectangle : Square
    {
        private int _width;
        private int _height;

        public void SetDimensions(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.FillRectangle(Brush, new System.Drawing.Rectangle(Left, Top, _width, _height));
        }
    }
}
