using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public abstract class Shape 
    {
        private SolidBrush _brush = new SolidBrush(Color.Chartreuse);
        private Pen _pen = new Pen(Color.FromArgb(73, 182, 33));
        private Panel _surface;
        private int _left;
        private int _top;

        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public SolidBrush Brush
        {
            get { return _brush; }
            set { _brush = value; }
        }

        public Pen Pen
        {
            get { return _pen; }
            set { _pen = value; }
        }

        public Panel Surface
        {
            get { return _surface; }
            set { _surface = value; }
        }

        public void SetPosition(int left, int top)
        {
            this._left = left;
            this._top = top;
        }

        public abstract void Draw();

    }
}
