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
            pictureBox7.Image = game.Construction(6);
            pictureBox8.Image = game.Construction(7);
        }

        Render game = new Render();
        private int number;
        Cell check = new Cell();
        static bool control = false;

        public bool Control
        {
            get { return control; }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            number = 0;
            Stroke(number);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            number = 0;
            Picter(number);
        }

        private void Stroke(int x)
        {
            switch (x)
            {
                case 0:
                    pictureBox1.Image = game.AccentuationConstruction(x);
                    break;
                case 1:
                    pictureBox2.Image = game.AccentuationConstruction(x);
                    break;
                case 2:
                    pictureBox3.Image = game.AccentuationConstruction(x);
                    break;
                case 3:
                    pictureBox4.Image = game.AccentuationConstruction(x);
                    break;
                case 4:
                    pictureBox5.Image = game.AccentuationConstruction(x);
                    break;
                case 5:
                    pictureBox6.Image = game.AccentuationConstruction(x);
                    break;
                case 6:
                    pictureBox7.Image = game.AccentuationConstruction(x);
                    break;
                case 7:
                    pictureBox8.Image = game.AccentuationConstruction(x);
                    break;
            }
        }

        private void Picter(int x)
        {
            switch (x)
            {
                case 0:
                    pictureBox1.Image = game.Construction(x);
                    break;
                case 1:
                    pictureBox2.Image = game.Construction(x);
                    break;
                case 2:
                    pictureBox3.Image = game.Construction(x);
                    break;
                case 3:
                    pictureBox4.Image = game.Construction(x);
                    break;
                case 4:
                    pictureBox5.Image = game.Construction(x);
                    break;
                case 5:
                    pictureBox6.Image = game.Construction(x);
                    break;
                case 6:
                    pictureBox7.Image = game.Construction(x);
                    break;
                case 7:
                    pictureBox8.Image = game.Construction(x);
                    break;
            }

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            number = 1;
            Stroke(number);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            number = 1;
            Picter(number);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            number = 2;
            Stroke(number);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            number = 2;
            Picter(number);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            number = 3;
            Stroke(number);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            number = 3;
            Picter(number);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            number = 4;
            Stroke(number);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            number = 4;
            Picter(number);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            number = 5;
            Stroke(number);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            number = 5;
            Picter(number);
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            number = 7;
            Stroke(number);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            number = 7;
            Picter(number);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        //    control = true;
        //    int i = game.I;
        //    int i2 = game.I2;
        //    check.Redraw(i, i2, number + 25);
        //    this.Close();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            number = 6;
            Stroke(number);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            number = 6;
            Picter(number);
        }
    }
}
