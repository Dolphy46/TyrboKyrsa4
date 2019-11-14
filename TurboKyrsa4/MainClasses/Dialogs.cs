using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboKyrsa4.MainClasses
{
    class Dialogs
    {
        Construction construction;
        DialogResult res = new DialogResult();
        bool conference = false;

        public bool InfoConference()
        {
            return conference;
        }

        public void Construction(Construction co)
        {
            construction = co;
        }

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
                MessageBox.Show("Члены конференции были рады видеть вас на собрании\nВы потратили один ход и получили + 20 рейтинга");
                conference = true;
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
                    MessageBox.Show("У вас недостаточно ресурсов для помощи\nВы получаете - " + r + " рейтинга, потому что не можите помочь");
                    construction.resources.Conference(false, r);
                }
            }
            else
            {
                construction.resources.Conference(false, r);
                MessageBox.Show("Страна очень разочарована вашем отказом\nВы получили  - " + r + " рейтинга.");
            }
        }

    }
}
