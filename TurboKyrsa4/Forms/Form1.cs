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
            Conference();
            Conclusion();
        }

        Render game = new Render();
        Cell check = new Cell();
        Construction construction = new Construction();
        private int moves = 30;
        DialogResult res = new DialogResult();


        public void Conference() //первый ход - конференция
        {
            DialogResult res = MessageBox.Show("Добро пожаловать в игру!\nВ первый ход игры вам предлагается посетить преветственную " +
                "конференцию на которой произойдет знакомство всех стран.\nЕсли вы согласитесь её посетить, то вам пибавить 20 баллов" +
                " рейтинга, так как это будет расцениваться как положительный знак.\nЕсли вы решите не присутсвовать на конференции, " +
                "то вы потеряеет 15 баллов рейтинга.\nПосещение конференции отнимет у вас один игровой ход, в течении которого вы не " +
                "сможите ничего сделать на карте.\n\nВы готовы посетить конференцию?", "Преветственная конференция", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                construction.resources.Conference(true, 20);
                moves--;
                MessageBox.Show("Члены конференции были рады видеть вас на собрании\nВы потратили один ход и получили + 20 рейтинга");
            }
            else
            {
                construction.resources.Conference(false, 15);
                MessageBox.Show("Члены конференции надеялись увидеть вас на собрании.\nВы получили - 15 рейтинга");
            }
        }

        public void HelpResources(int x, int x1) // помощь стране ресурсами
        {
            string s = "";
            if (x == 0)
                s = "железа";
            else
                 if (x == 1)
                s = "дерева";
            else
                 if (x == 2)
                s = "угля";
            else
               if (x == 3)
                s = "урана";
            else
                s = "еды";

             res = MessageBox.Show("Одна из стран просит помочь ей ресурсами.\nЕсли вы согласны, то это принесёт 5 баллов " +
                "рейтинга.\nЕсли вы не согласны это отнимет 5 баллово рейтинга.\n\nГотовы ли вы перечислить стране " + x1 + " " + s + "?",
                "Помощь", MessageBoxButtons.YesNo);

            ResNew(5, x, x1);
        } 

        public void HelpMoney(int x)// помощь стране деньгами
        {
            res = MessageBox.Show("Одна из стран просит помочь ей монетами.\nЕсли вы согласны, то это принесёт 10 баллов " +
               "рейтинга.\nЕсли вы не согласны это отнимет 10 баллово рейтинга.\n\nГотовы ли вы перечислить стране " + x + " монет?",
               "Помощь", MessageBoxButtons.YesNo);
            ResNew(10, 5, x);
        }

        public void ResNew(int r, int x, int x1) //изменение данных по количеству ресурсов при диалоге с другмими странами
        {
            if (res == DialogResult.Yes)
            {
                construction.resources.HelpResources(x, x1);
                if (construction.resources.InfoTest())
                {
                    construction.resources.Conference(true, r);
                    MessageBox.Show("Страна благодарна вам за помощь\nВы получили + " + r + " рейтигна.");
                }
                else
                {
                    MessageBox.Show("У вас недостаточно ресурсов для помощи\nВы получаете - " + r +" рейтинга, потому что не можите помочь");
                    construction.resources.Conference(false, r);
                }
            }
            else
            {
                construction.resources.Conference(false, r);
                MessageBox.Show("Страна очень разочарована вашем отказом\nВы получили  - " + r + " рейтинга.");
            }
        }

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

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e) 
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

                if(moves%3 == 0) //каждые три хода - вызов функции для помощи ресурсами
                {
                    HelpResources(random.Next(0, 4), random.Next(10, 30));
                    Conclusion();
                }

                if(moves == 20 || moves ==8) //20 и 8 ход - вызов функции для помощи монетами
                {
                    HelpMoney(random.Next(500, 2500));
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
