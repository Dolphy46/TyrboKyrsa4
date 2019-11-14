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
        Random random = new Random();
        Dialogs dialogs = new Dialogs();
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
                    if (check2[2] == 25|| check2[2] == 26 || check2[2] == 27|| check2[2] == 30)
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

        private void button1_Click(object sender, EventArgs e) 
        {
            dialogs.Construction(construction); //каждый ход передает экзепляр класса Construction в класс Dialogs
            if (moves == 30)
            {
                dialogs.Conference();
                if(dialogs.InfoConference() != true)
                    moves--;
            }
            
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

                if(moves%3 == 0) //каждые три хода - вызов функции для помощи ресурсами
                {
                    dialogs.HelpResources(random.Next(0, 4), random.Next(10, 30));
                    Conclusion();
                }

                if(moves == 20 || moves ==8) //20 и 8 ход - вызов функции для помощи монетами
                {
                    dialogs.HelpMoney(random.Next(500, 2500));
                    Conclusion();
                }
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
