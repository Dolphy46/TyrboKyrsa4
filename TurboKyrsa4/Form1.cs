using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //Bitmap map = new Bitmap(1280, 960);
        //Graphics graph;

        //public void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
       
        //}

        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    int x1 = e.X, y1 = e.Y;
        //    graph = Graphics.FromImage(map);
        //    if (x1 > 178 && y1 > 49)
        //    {
        //        int x = e.X, count = -1, y = e.Y, count2 = -1;
        //        while (x > 178)
        //        {
        //            x -= 123;
        //            count++;
        //        }
        //        while (y > 50)
        //        {
        //            y -= 123;
        //            count2++;
        //        }
        //        Image globalmap = Image.FromFile("MAP V1.jpg");
        //        graph.DrawImage(globalmap, 1, 1, 1279, 959);

        //        graph.DrawLine(new Pen(Color.Orange, 10), 203 + 123 * count, 57 + 123 * count2, 272 + 123 * count, 57 + 123 * count2);
        //        graph.DrawLine(new Pen(Color.Orange, 10), 203 + count * 123, 167 + count2 * 123, 272 + count * 123, 167 + count2 * 123);
        //        graph.DrawLine(new Pen(Color.Orange, 10), 203 + 123 * count, 167 + count2 * 123, 177 + count * 123, 107 + count2 * 123);
        //        graph.DrawLine(new Pen(Color.Orange, 10), 273 + count * 123, 165 + count2 * 123, 297 + count * 123, 107 + count2 * 123);
        //        graph.DrawLine(new Pen(Color.Orange, 10), 177 + count * 123, 107 + count2 * 123, 202 + count * 123, 57 + count2 * 123);
        //        graph.DrawLine(new Pen(Color.Orange, 10), 297 + count * 123, 107 + count2 * 123, 272 + count * 123, 57 + count2 * 123);
        //        pictureBox1.Image = map;
        //    }
        //    else
        //    {
        //        pictureBox1.Image = game.RenderMap();
        //    }
        //}
    }
}
