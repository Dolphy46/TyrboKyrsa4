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
        }
        Render game = new Render();

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
        }

        //2; 0  1280; 960
    }
}
