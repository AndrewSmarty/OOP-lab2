using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace GeometricFigures1
{
    public class Shapes
    {
        private List<Shape> _shapes;
        private int _currentFigureNum;
        private Timer _timer;

        public Shapes()
        {
            _shapes = new List<Shape>();
            _timer = new Timer();
            _currentFigureNum = 0;
        }

        public void AddFigure(Shape shape)
        {
            _shapes.Add(shape);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_currentFigureNum < _shapes.Count)
                _shapes.ElementAt(_currentFigureNum++).Draw();
            else
            {
                _currentFigureNum = 0;
                _timer.Dispose();
            }
        }

        public void Draw()
        {
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Start();
        }
    }
}
