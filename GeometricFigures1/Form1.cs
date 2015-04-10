using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeometricFigures1
{
    public partial class Form1 : Form
    {
        private readonly Rectangle _rect;
        private readonly Line _line;
        private readonly Triangle _triangle;
        private readonly Circle _circle;
        private readonly Ellipse _ellipse;
        private readonly Square _square;
        private readonly Shapes _shapes;

        public Form1()
        {
            InitializeComponent();
            _rect = new Rectangle()
            _circle = new Circle();
            _triangle = new Triangle();
            _line = new Line();
            _ellipse = new Ellipse();
            _square = new Square();
            _shapes = new Shapes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rect.Draw();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            circle.Draw();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            triangle.Draw();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            line.Draw();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            square.Draw();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ellipse.Draw();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rect
            rect.SetPosition(80, 80);
            rect.SetDimensions(200, 300);
            rect.Surface = panel1;


            circle.SetPosition(80, 120);
            circle.SetRadius(100);
            circle.Surface = panel1;


            square.SetSide(200);
            square.Surface = panel1;
            square.SetPosition(100, 100);


            ellipse.SetPosition(80, 80);
            ellipse.SetDimensions(200, 300);
            ellipse.Surface = panel1;
            

            triangle.SetPoints(new Point[]{
                                    new Point(100, 300), 
                                    new Point(300, 300), 
                                    new Point(200, 100)
                                });
            triangle.Surface = panel1;


            line.SetPoints(new Point[]{
                                    new Point(80, 80), 
                                    new Point(280, 380)
                                });
            line.Surface = panel1;


            _shapes.AddFigure(rect);
            _shapes.AddFigure(circle);
            _shapes.AddFigure(ellipse);
            _shapes.AddFigure(triangle);
            _shapes.AddFigure(line);
            _shapes.AddFigure(square);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _shapes.Draw();
        }
    }
}
