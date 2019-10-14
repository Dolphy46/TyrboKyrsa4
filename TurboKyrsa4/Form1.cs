using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboKyrsa4.MainClasses;

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
        Cell check = new Cell();
        Construction construction = new Construction();
        static int cell;
        static int i;
        static int i2;

        public int I2
        {
            get { return i2; }
        }

        public int I
        {
            get { return i; }
        }

        public int Cell
        {
            get { return cell;}
            set { cell = value;}
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int[] check = game.FindCoords(e.X, e.Y);
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
            if (check[2] != -1)
            {
                if (check[2] == 1 || check[2] == 7 || check[2] == 6 || (check[2] >= 20 && check[2] < 24))
                {
                    i = check[3];
                    i2 = check[4];
                    cell = check[2];
                    construction.ShowDialog();
                }
                else
                    MessageBox.Show("Это не ваша территория.\nВыбирете свою ячейку");
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
        }

      
        //2; 0  1280; 960
    }
}
