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
            int x=178, y=75;
            graph = Graphics.FromImage(map);
            Image globalmap = Image.FromFile("MAP V1.jpg");
            Image cell = Image.FromFile("Cell.png");
            Image mountains1 = Image.FromFile("Mountains1.png");
            Image mountains2 = Image.FromFile("Mountains2.png");
            Image mountains3 = Image.FromFile("Mountains3.png");
            Image mountains4 = Image.FromFile("Mountains4.png");
            Image plain = Image.FromFile("Plain.png");
            Image meadow = Image.FromFile("Meadow.png");
            Image town1 = Image.FromFile("Town1.png");
            graph.DrawImage(globalmap, 1, 1, 1279, 959);
            bool count = true,count1=true;
            if (count1 == true)
            {
                getmarks.InfoAboutMap();
                count1 = false;
            }
            bool[,] marks = getmarks.GetinfoAboutMap();
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    if(marks[i,i2]==true)
                    graph.DrawImage(cell, x, y, 123, 123);                   
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
            x = 178;
            y = 75;
            int[,] location = new int[15, 7];
            location = getmarks.GetLocation();
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    switch (location[i, i2])
                    {
                        case 0:
                            graph.DrawImage(plain, x, y, 123, 123);
                            break;
                        case 1:
                            graph.DrawImage(meadow, x, y, 123, 123);
                            break;
                        case 2:
                            graph.DrawImage(mountains1, x, y, 123, 123);
                            break;
                        case 3:
                            graph.DrawImage(mountains2, x, y, 123, 123);
                            break;
                        case 4:
                            graph.DrawImage(mountains3, x, y, 123, 123);
                            break;
                        case 5:
                            graph.DrawImage(mountains4, x, y, 123, 123);
                            break;
                        case 6:
                            graph.DrawImage(town1, x, y, 123, 123);
                            break;
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
            x = 178;
            y = 75;
            return map;
        }



    }
}
