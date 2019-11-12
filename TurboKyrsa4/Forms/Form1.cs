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
            check.Inic();
            game.InicIm();
            game.GetMass(check.GetMap(), check.GetWater());
            pictureBox1.Image = game.RenderMap();
            Conclusion();
        }
        Render game = new Render();
        Cell check = new Cell();
        Construction construction = new Construction();
        private int moves = 30;
        
        public void Conclusion()
        {
            label1.Text = "Рейтинг: " + construction.resources.InfoRating().ToString() + "\nБаланс города: " + construction.resources.InfoMoney().ToString();
            label2.Text = construction.resources.GetLabel2();
            label3.Text = construction.resources.GetLabel3();
            label4.Text = "Количество ходов: " + moves;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            int[] check2 = game.FindCoords(e.X, e.Y);
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
            if (check2[2] != -1)
            {
                if (check2[2] == 1 || check2[2] == 7 || check2[2] == 6 || (check2[2] >= 20 && check2[2] <= 32 && check2[2] != 24))
                    if (check2[2] == 25|| check2[2] == 26 || check2[2] == 27|| check2[2] == 28 || check2[2] == 30)
                        MessageBox.Show("На этой территории уже построено здание");
                    else
                    { 
                        construction.InfC(check2[2]);
                        construction.Info();
                        construction.ShowDialog();
                        construction.Clean();
                        if (construction.GetCheck())
                        {
                            check.Redraw(game.SendI()[0], game.SendI()[1], construction.GetBilding());
                            construction.SetCheck();
                        }
                    }
                 else
                    MessageBox.Show("Это не ваша территория.\nВыбирете свою ячейку");
            }           
            Conclusion();
            game.GetMass(check.GetMap(), check.GetWater());
            pictureBox1.Image = game.RenderMap();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = game.Accentuation(e.X, e.Y);
            game.GetMass(check.GetMap(), check.GetWater());
        }

        private void button1_Click(object sender, EventArgs e) // ПОКА КНОПКА ТОЛЬКО ДОБАВЛЯЕТ РЕСУРСЫ ПО ШАХТЕ, ЛЕСОРУБКЕ И ФЕРМЕ И ДЕНЬГИ КАЖДЫЙ ХОД!!!
        {
            if (moves != 1)
            {
                construction.resources.SetMoney();
                if (construction.resources.numberMine > 0)
                    construction.resources.PlusMine();
                if (construction.resources.numberSawmill > 0)
                    construction.resources.PlusSwamill();
                if (construction.resources.numberFarm > 0)
                    construction.resources.PlusFarm();
                moves--;
                Conclusion();
            }
            else
            {
                moves--;
                Conclusion();
                MessageBox.Show("Конец игры.Дотвиданиня!");
                Application.Exit();
            }
        }

    }
}
