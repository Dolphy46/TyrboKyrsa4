using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboKyrsa4.MainClasses
{
    public partial class Construction : Form
    {
        public Construction()
        {
            InitializeComponent();
            pictureBox1.Image = game.Construction(0);
            pictureBox2.Image = game.Construction(1);
            pictureBox3.Image = game.Construction(2);
            pictureBox4.Image = game.Construction(3);
            pictureBox5.Image = game.Construction(4);
            pictureBox6.Image = game.Construction(5);
            pictureBox8.Image = game.Construction(7);
        }

        Render game = new Render();
        private int number;
        Form1 f = new Form1();
        Cell check = new Cell();

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            number = 25;
            Stroke(number);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            number = 25;
            Picter(number);
        }

        private void Stroke(int x)
        {
            switch (x)
            {
                case 25:
                    pictureBox1.Image = game.AccentuationConstruction(x);
                    break;
                case 26:
                    pictureBox2.Image = game.AccentuationConstruction(x);
                    break;
                case 27:
                    pictureBox3.Image = game.AccentuationConstruction(x);
                    break;
                case 28:
                    pictureBox4.Image = game.AccentuationConstruction(x);
                    break;
                case 29:
                    pictureBox5.Image = game.AccentuationConstruction(x);
                    break;
                case 30:
                    pictureBox6.Image = game.AccentuationConstruction(x);
                    break;
                case 31:
                    pictureBox7.Image = game.AccentuationConstruction(x);
                    break;
                case 32:
                    pictureBox8.Image = game.AccentuationConstruction(x);
                    break;
            }
        }

        private void Picter(int x)
        {
            switch (x)
            {
                case 25:
                    pictureBox1.Image = game.Construction(x);
                    break;
                case 26:
                    pictureBox2.Image = game.Construction(x);
                    break;
                case 27:
                    pictureBox3.Image = game.Construction(x);
                    break;
                case 28:
                    pictureBox4.Image = game.Construction(x);
                    break;
                case 29:
                    pictureBox5.Image = game.Construction(x);
                    break;
                case 30:
                    pictureBox6.Image = game.Construction(x);
                    break;
                case 31:
                    pictureBox7.Image = game.Construction(x);
                    break;
                case 32:
                    pictureBox8.Image = game.Construction(x);
                    break;
            }

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            number = 26;
            Stroke(number);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            number = 26;
            Picter(number);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            number = 27;
            Stroke(number);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            number = 27;
            Picter(number);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            number = 28;
            Stroke(number);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            number = 28;
            Picter(number);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            number = 29;
            Stroke(number);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            number = 29;
            Picter(number);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            number = 30;
            Stroke(number);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            number = 30;
            Picter(number);
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            number = 32;
            Stroke(number);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            number = 32;
            Picter(number);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            check.Redraw(f.I, f.I2, number);
        }
    }
}
