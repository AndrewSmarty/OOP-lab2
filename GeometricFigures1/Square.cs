using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public class Square : Shape
    {
        private int _side;

        public Square()
        {
            _side = 0;
        }

        public void SetSide(int side)
        {
            this._side = side;
        }

        public override void Draw()
        {
            Surface.Refresh();
            var graphics = Surface.CreateGraphics();
            graphics.FillRectangle(Brush, new System.Drawing.Rectangle(Left, Top, _side, _side));
        }
    }
}
