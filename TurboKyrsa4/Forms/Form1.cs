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
using TurboKyrsa4.MainClasses;

namespace TurboKyrsa4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            game.InitializeMass();
            check.InfoAboutLocation();
            check.Record();
            pictureBox1.Image = game.RenderMap();
            Conclusion();
        }

        Render game = new Render();
        Cell check = new Cell();
        Construction construction = new Construction();
        

        public void Conclusion()
        {
            label1.Text = "Рейтинг: " + construction.resources.InfoRating().ToString();
            label2.Text = construction.resources.GetLabel2();
            label3.Text = construction.resources.GetLabel3();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int[] check = game.FindCoords(e.X, e.Y);
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
            construction.GetI(game.SendI()[0], game.SendI()[1]);
            if (check[2] != -1)
            {
                if (check[2] == 1)
                    MessageBox.Show("Пока в городе невозможно ничего построить");
                else
                {
                    if (check[2] == 7 || check[2] == 6 || (check[2] >= 20 && check[2] <= 32 && check[2] != 24))
                    {
                        if (check[2] >= 25)
                            MessageBox.Show("На этой территории уже построено здание");
                        else
                            construction.ShowDialog();
                    }
                    else
                        MessageBox.Show("Это не ваша территория.\nВыбирете свою ячейку");
                }
            }
            Conclusion();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
        }

      
        //2; 0  1280; 960
    }
}
