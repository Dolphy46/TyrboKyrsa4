﻿using System;
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
            cheacking = false;
        }

        Render window = new Render();

        int infcoords;
        int infoMoves;

        public void InMoves(int inf) //какой ход
        {
            infoMoves = inf;
        }

        public void InfC(int inf) //какая ячейка
        {
            infcoords = inf;
        }

        public void Info()
        {
            if (infcoords == 1)
            {
                this.Width = 600;
                this.Height = 550;
                label1.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                if (resources.park > 0)
                {
                    button1.Enabled = false;
                    label24.Text = "К постройке больше недоступен";
                }

                if (resources.shop > 3)
                {
                    button2.Enabled = false;
                    label22.Text = "К постройке больше недоступен";
                }

                if (resources.temple > 0)
                {
                    button3.Enabled = false;
                    label20.Text = "К постройке больше недоступен";
                }
            }
            else
            {
                if (infcoords == 29 || infcoords == 31 || infcoords == 32)
                {
                    this.Width = 500;
                    this.Height = 250;
                    button4.Visible = true;
                    label25.Visible = true;
                    if (infcoords == 31)
                        label25.Text = "Количество произведённого ресурса: 100 солдат\nКоличество потраченных ресурсов:" +
                            " 10 еды, 150 монет\nКаждые 100 солдат принесут - 5 к рейтингу";
                    if (infcoords == 32)
                        label25.Text = "Количество произведённого ресурса: 1 боеголовка\nКоличество потраченных ресурсов:" +
                            " 20 железа, 10 урана\nКаждая боеголовка принесёт - 25 к рейтингу";
                }
                else
                {
                    if (infcoords == 28)
                    {
                        this.Width = 450;
                        this.Height = 550;
                        button1.Text = "Купить";
                        button2.Text = "Купить";
                        button3.Text = "Купить";
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        label26.Visible = true;
                        label27.Visible = true;
                        label28.Visible = true;
                        label24.Text = "10 железа = 200 монет";
                        label22.Text = "10 дерева = 100 монет";
                        label20.Text = "10 угля = 300 монет";
                        label26.Text = "1 уран = 500 монет";
                        label27.Text = "10 еды = 300 монет";
                        label24.Visible = true;
                        label20.Visible = true;
                        label22.Visible = true;
                        if (resources.InfoMoney() >= 200)
                            button1.Enabled = true;
                        else
                        {
                            label24.Text = "Недостаточно монет для покупки";
                            button1.Enabled = false;
                        }

                        if (resources.InfoMoney() >= 100)
                            button2.Enabled = true;
                        else
                        {
                            label22.Text = "Недостаточно монет для покупки";
                            button2.Enabled = false;
                        }

                        if (resources.InfoMoney() >= 300)
                            button3.Enabled = true;
                        else
                        {
                            label20.Text = "Недостаточно монет для покупки";
                            button3.Enabled = false;
                        }

                        if (resources.InfoMoney() >= 500)
                            button5.Enabled = true;
                        else
                        {
                            label26.Text = "Недостаточно монет для покупки";
                            button5.Enabled = false;
                        }

                        if (resources.InfoMoney() >= 300)
                            button6.Enabled = true;
                        else
                        {
                            label27.Text = "Недостаточно монет для покупки";
                            button6.Enabled = false;
                        }
                    }
                    else
                    {
                        this.Width = 600;
                        this.Height = 550;
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                        label15.Visible = true;
                        label16.Visible = true;
                        label17.Visible = true;
                        label18.Visible = true;
                        pictureBox1.Image = window.Construction(0);
                        pictureBox2.Image = window.Construction(1);
                        pictureBox3.Image = window.Construction(2);
                        pictureBox4.Image = window.Construction(3);
                        pictureBox5.Image = window.Construction(4);
                        pictureBox6.Image = window.Construction(5);
                        pictureBox7.Image = window.Construction(6);
                        pictureBox8.Image = window.Construction(7);
                    }
                }
            }
        }

        public void Clean()
        {
            if (infcoords == 1)
            {
                label1.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {

                if (infcoords == 29 || infcoords == 31 || infcoords == 32)
                {
                    button4.Visible = false;
                    label25.Visible = false;
                }
                else
                {
                    if (infcoords == 28)
                    {
                        label24.Text = "(Возможно построить всего один парк за игру) \n+ 10 монет каждый ход \nРейтинг: Нейтрально";
                        label22.Text = "(Возможно построить всего 3 торгового центра за игру) \n+ 30 монет каждый ход \nРейтинг: Нейтрально";
                        label20.Text = "(Возможно построить всего 1 храм за игру) \n+ 300 монет каждый ход \nРейтинг: Нейтрально";
                        label24.Visible = false;
                        label22.Visible = false;
                        label20.Visible = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        label26.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        button1.Text = "Построить парк";
                        button2.Text = "Построить торговый цент";
                        button3.Text = "Построить храм";
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label16.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;
                    }
                }
            }           
        }

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
            if (resources.port == true && number == 3)
            {
                MessageBox.Show("Можно построить всего один порт за игру.");
            }
            else
            {
                resources.SetNumberResours(number);
                if (resources.InfoTest() == true)
                {
                    bilding = number + 25;
                    cheacking = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("У вас недостаточно монет или ресурсов.\n                   Проверте свой баланс.");
                    this.Close();
                }
            }
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            number = 6;
            Stroke(number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Купить")
            {
                if (resources.InfoMoney() >= 200)
                    resources.Buying(0);
                else
                {
                    MessageBox.Show("Недостаточно монет для покупки");
                    this.Close();
                }

            }
            else
            {
                number = 8;
                resources.SetNumberResours(number);
                if (resources.InfoTest())
                {
                    button1.Enabled = false;
                    label1.Text = "Количество построек: \nПарк: " + resources.park + "\nТорговый центр: " + resources.shop +
                        "\nЦерковь: " + resources.temple;
                    label24.Text = "К постройке больше недоступен";
                }
                else
                {
                    MessageBox.Show("У вас недостаточно монет!");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (button2.Text == "Купить")
                {
                   if(resources.InfoMoney() >= 100)
                      resources.Buying(1);
                   else
                   {
                      MessageBox.Show("Недостаточно монет для покупки");
                      this.Close();
                   }
                }
                else
                {
                    number = 9;
                    resources.SetNumberResours(number);
                    if (resources.InfoTest())
                    {
                        if(resources.shop == 3)
                        {
                           button2.Enabled = false;
                        }
                        label1.Text = "Количество построек: \nПарк: " + resources.park + "\nТорговый центр: " + resources.shop +
                           "\nЦерковь: " + resources.temple;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно монет!");
                        this.Close();
                    }
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Купить")
            {
                if(resources.InfoMoney() >= 300)
                resources.Buying(2);
                else
                {
                    MessageBox.Show("Недостаточно монет для покупки");
                    this.Close();
                }
            }
            else
            {
                number = 10;
                resources.SetNumberResours(number);
                if (resources.InfoTest())
                {
                    button3.Enabled = false;
                    label1.Text = "Количество построек: \nПарк: " + resources.park + "\nТорговый центр: " + resources.shop +
                        "\nЦерковь: " + resources.temple;
                    label20.Text = "К постройке больше недоступен";
                }
                else
                {
                    MessageBox.Show("У вас недостаточно монет!");
                    this.Close();
                }
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (infcoords == 31)
                resources.MotionMen();
            else
                if (infcoords == 32)
                resources.MotionWarhead();
            else
                resources.MotionTank();
            if (resources.InfoTest() == false)
                MessageBox.Show("У вас недостаточно ресурсов для производства.");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(resources.InfoMoney() >= 500)
            resources.Buying(3);
            else
            {
                MessageBox.Show("Недостаточно монет для покупки");
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(resources.InfoMoney() >= 300)
            resources.Buying(4);
            else
            {
                MessageBox.Show("Недостаточно монет для покупки");
                this.Close();
            }
        }
    }
}
