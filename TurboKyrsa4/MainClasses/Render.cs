using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboKyrsa4
{
    public class Render
    {
        Bitmap map = new Bitmap(1280, 960);
        Graphics graph;
        Cell getmarks = new Cell();

        public Bitmap RenderMap()  // Главная функция отрисовки карты.
        {
            Image[] images = new Image[24];
            int x=178, y=75;
            graph = Graphics.FromImage(map);
            Image globalmap = Image.FromFile("MAP V1.jpg");
            images[0] = Image.FromFile("Dubai.png");
            images[1] = Image.FromFile("Moscow.png");
            images[2] = Image.FromFile("NewYork.png");
            images[3] = Image.FromFile("mountain_savannah.png");
            images[4] = Image.FromFile("mountain_tropics.png");
            images[5] = Image.FromFile("mountain_tundra.png");
            images[6] = Image.FromFile("mountain_winter_1.png");
            images[7] = Image.FromFile("mountain_winter_2.png");
            images[8] = Image.FromFile("savannah_1.png");
            images[9] = Image.FromFile("savannah_2.png");
            images[10] = Image.FromFile("savannah_3.png");
            images[11] = Image.FromFile("savannah_4.png");
            images[12] = Image.FromFile("tropics_1.png");
            images[13] = Image.FromFile("tropics_2.png");
            images[14] = Image.FromFile("tropics_3.png");
            images[15] = Image.FromFile("tropics_4.png");
            images[16] = Image.FromFile("tundra_1.png");
            images[17] = Image.FromFile("tundra_2.png");
            images[18] = Image.FromFile("tundra_3.png");
            images[19] = Image.FromFile("tundra_4.png");
            images[20] = Image.FromFile("winter_1.png");
            images[21] = Image.FromFile("winter_2.png");
            images[22] = Image.FromFile("winter_3.png");
            images[23] = Image.FromFile("winter_4.png");
            graph.DrawImage(globalmap, 1, 1, 1279, 959);
            bool count = true, count1=true;          
            if (count1 == true)
            {
                getmarks.InfoAboutMap();
                getmarks.InfoAboutLocation();
                count1 = false;
            }
            int[,] location = getmarks.GetLocation();
            bool[,] marks = getmarks.GetinfoAboutMap();
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    if (marks[i, i2] == true && location[i,i2] != -1)
                    {
                        int picture = location[i, i2];
                        
                        graph.DrawImage(images[picture], x, y, 123, 123);
                    }

                    x += 178;
                }
                if (count == true)
                {
                    x = 90;
                    y += 51;
                    count = false;
                }
                else
                {
                    x = 179;
                    y += 51;
                    count = true;
                }
            }         
            return map;
        }

        public Bitmap Accentuation(int x,int y)
        {
            int count=0, count2=0;
            map = RenderMap();
            if (x>178&&y>75)
            {
                while (x > 300)
                {
                    x -= 179;
                    count++;
                }
                while (y > 186)
                {
                    y -= 123;
                    count2++;
                }
            }
            graph.DrawLine(new Pen(Color.Orange, 5), 209 + 179 * count, 84 + 179 * count2, 264 + 179 * count, 84 + 179 * count2);
            graph.DrawLine(new Pen(Color.Orange, 5), 264 + count * 179, 84 + count2 * 179, 300 + count * 179, 135 + count2 * 179);
            graph.DrawLine(new Pen(Color.Orange, 5), 300 + 179 * count, 135 + count2 * 179, 270 + count * 179, 186 + count2 * 179);
            graph.DrawLine(new Pen(Color.Orange, 5), 270 + count * 179, 186 + count2 * 179, 211 + count * 179, 186 + count2 * 179);
            graph.DrawLine(new Pen(Color.Orange, 5), 211 + count * 179, 186 + count2 * 179, 178 + count * 179, 133 + count2 * 179);
            graph.DrawLine(new Pen(Color.Orange, 5), 178 + count * 179, 133 + count2 * 179, 209 + count * 179, 84 + count2 * 179);
            return map;
        }

    }
}
