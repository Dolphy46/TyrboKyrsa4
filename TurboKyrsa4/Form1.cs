using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboKyrsa4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = game.RenderMap();
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //Point[] P = new Point[6];
            //P[0] = new Point(25, 7);
            //P[1] = new Point(button1.Width - 25, 7);
            //P[2] = new Point(button1.Width - 3, button1.Height / 2);
            //P[3] = new Point(button1.Width - 25, button1.Height - 3);
            //P[4] = new Point(25, button1.Height - 3);
            //P[5] = new Point(3, button1.Height / 2);
            //path.AddPolygon(P);
            //Region RG = new Region(path);
            //button1.BackgroundImage= Image.FromFile("Moscow.png");
            //button1.Region = RG;
        }
        Render game = new Render();

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Convert.ToString(game.Accentuation(e.X, e.Y)[0])+" "+ Convert.ToString(game.Accentuation(e.X, e.Y)[1]));
            if (game.Accentuation(e.X, e.Y)[0] == 1)
                label2.Text = "false";
            else
                label2.Text = "true";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X:" + e.X + " Y:" + e.Y;

            if (game.Accentuation(e.X, e.Y)[0] == 1)
                label2.Text = "false";
            else
                label2.Text = "true";
        }
    }
}
