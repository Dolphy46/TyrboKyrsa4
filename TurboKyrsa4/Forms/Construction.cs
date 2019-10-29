using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboKyrsa4.Forms;

namespace TurboKyrsa4.MainClasses
{
    public partial class Construction : Form
    {
        bool cheacking;
        public Construction()
        {
            InitializeComponent();
            pictureBox1.Image = window.Construction(0);
            pictureBox2.Image = window.Construction(1);
            pictureBox3.Image = window.Construction(2);
            pictureBox4.Image = window.Construction(3);
            pictureBox5.Image = window.Construction(4);
            pictureBox6.Image = window.Construction(5);
            pictureBox7.Image = window.Construction(6);
            pictureBox8.Image = window.Construction(7);
            cheacking = false;
        }

        Render window = new Render();
        public Resources resources = new Resources();
        private int number;

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
                    pictureBox1.Image = window.AccentuationConstruction(x);
                    break;
                case 1:
                    pictureBox2.Image = window.AccentuationConstruction(x);
                    break;
                case 2:
                    pictureBox3.Image = window.AccentuationConstruction(x);
                    break;
                case 3:
                    pictureBox4.Image = window.AccentuationConstruction(x);
                    break;
                case 4:
                    pictureBox5.Image = window.AccentuationConstruction(x);
                    break;
                case 5:
                    pictureBox6.Image = window.AccentuationConstruction(x);
                    break;
                case 6:
                    pictureBox7.Image = window.AccentuationConstruction(x);
                    break;
                case 7:
                    pictureBox8.Image = window.AccentuationConstruction(x);
                    break;
            }
        }

        private void Picter(int x)
        {
            switch (x)
            {
                case 0:
                    pictureBox1.Image = window.Construction(x);
                    break;
                case 1:
                    pictureBox2.Image = window.Construction(x);
                    break;
                case 2:
                    pictureBox3.Image = window.Construction(x);
                    break;
                case 3:
                    pictureBox4.Image = window.Construction(x);
                    break;
                case 4:
                    pictureBox5.Image = window.Construction(x);
                    break;
                case 5:
                    pictureBox6.Image = window.Construction(x);
                    break;
                case 6:
                    pictureBox7.Image = window.Construction(x);
                    break;
                case 7:
                    pictureBox8.Image = window.Construction(x);
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


        int bilding;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            resources.SetNumberResours(number);
            if (resources.test == true)
            {
                if (resources.port == true && number == 4)
                {
                    MessageBox.Show("Можно построить всего один порт за игру.");
                    this.Close();
                }
                else
                {
                    bilding = number + 25;
                    cheacking = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("У вас недостаточно монет или ресурсов.\n                   Проверте свой баланс.");
                this.Close();
            }
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

        public int GetBilding()
        {
            return bilding;
        }

        public bool GetCheck()
        {
            return cheacking;
        }

        public void SetCheck()
        {
            cheacking = false;
        }
    }
}
