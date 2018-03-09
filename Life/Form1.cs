using System;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            Graphics r = this.CreateGraphics();
            Pen ceruza0 = new Pen(Brushes.Black);
            bool[,] eletter = new bool[100, 100];
            for (int i = 0; i < 1000; i += 10)
            {
                for (int j = 0; j < 1000; j += 10)
                {
                    //if ()
                    {

                    }
                }
            }
            r.FillRectangle(Brushes.Black, 0, 0, 10, 10);
        }
        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Graphics r = this.CreateGraphics();
        //    int X = Cursor.Position.X;
        //    int Y = Cursor.Position.Y;
        //    for (int i = 0; i < 1000; i += 10)
        //    {
        //        r.FillRectangle(Brushes.Black, X, Y, 10, 10);
        //    }
        //}
    }
}
