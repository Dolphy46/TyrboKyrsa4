using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboKyrsa4.MainClasses;

namespace TurboKyrsa4
{
    public class Render
    {
        Bitmap map = new Bitmap(1280, 960);
        Graphics graph;
        Cell getmarks = new Cell();

        private int speciali2, speciali;

        public int[] SendI()
        {
            int[] numbers = new int[] {speciali,speciali2};
            return numbers;
        }

        public void InitializeMass()
        {
            getmarks.InfoAboutMap();
            getmarks.InfoAboutLocation();
        }

        public Bitmap RenderMap()  // Главная функция отрисовки карты.
        {
            int x=138, y=75;
            graph = Graphics.FromImage(map);
            Image globalmap = Image.FromFile("MAP V1.jpg");
            Image[] images = new Image[33];
            images[0] = Image.FromFile("Dubai.png");
            images[1] = Image.FromFile("Moscow.png");
            images[2] = Image.FromFile("Washington.png");
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
            images[24] = Image.FromFile("OON.png");
            images[25] = Image.FromFile("mine_winter.png");
            images[26] = Image.FromFile("sawmill_winter.png");
            images[27] = Image.FromFile("farm_winter.png");
            images[28] = Image.FromFile("port_winter.png");
            images[29] = Image.FromFile("plant_winter.png");
            images[30] = Image.FromFile("windturbine_winter.png");
            images[31] = Image.FromFile("casern_winter.png");
            images[32] = Image.FromFile("laboratory_winter.png");
            graph.DrawImage(globalmap, 1, 1, 1279, 959);                                    
            bool count = true;
            int[,] location = getmarks.GetLocation();
            bool[,] marks = getmarks.GetinfoAboutMap();
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    if (marks[i, i2] == true)
                    {
                        graph.DrawImage(images[location[i,i2]], x, y, 123, 123);
                    }
                    x += 185;
                }
                if (count == true)
                {
                    x = 46;
                    y += 51;
                    count = false;
                }
                else
                {
                    x = 138;
                    y += 51;
                    count = true;
                }
            }         
            return map;
        }

        public Bitmap Accentuation(int x, int y) // Возвращает карту с отрисованным выделением
        {
            Bitmap map = RenderMap();
            int[] coords = FindCoords(x, y);
            if (coords[2] != -1)
            {
                if (coords[2] == 1 || coords[2] == 7 || coords[2] == 6 || (coords[2] >= 20 && coords[2] < 24))
                {
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] - 30, coords[1] - 50, coords[0] + 30, coords[1] - 50);
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] + 30, coords[1] - 50, coords[0] + 62, coords[1]);
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] + 62, coords[1], coords[0] + 30, coords[1] + 50);
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] + 30, coords[1] + 50, coords[0] - 30, coords[1] + 50);
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] - 30, coords[1] + 50, coords[0] - 62, coords[1]);
                    graph.DrawLine(new Pen(Color.Green, 5), coords[0] - 62, coords[1], coords[0] - 30, coords[1] - 50);
                }
                else
                {
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] - 30, coords[1] - 50, coords[0] + 30, coords[1] - 50);
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] + 30, coords[1] - 50, coords[0] + 62, coords[1]);
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] + 62, coords[1], coords[0] + 30, coords[1] + 50);
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] + 30, coords[1] + 50, coords[0] - 30, coords[1] + 50);
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] - 30, coords[1] + 50, coords[0] - 62, coords[1]);
                    graph.DrawLine(new Pen(Color.Red, 5), coords[0] - 62, coords[1], coords[0] - 30, coords[1] - 50);
                }
            }
            return map;
        }

        public int[] FindCoords(int x, int y) // Ищет нужный шестиугольник по координатам мыши
        {
            int[,] location = getmarks.GetLocation();
            bool[,] info = getmarks.GetinfoAboutMap();
            int x1 = 200, y1 = 135;
            bool count = true;
            int[] coords = new int[3];
            coords[2] = -1;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    if (Check(x, y, x1, y1) == true)
                    {
                        if (info[i, i2])
                        {
                            coords[0] = x1;
                            coords[1] = y1;
                            speciali = i;
                            speciali2 = i2;
                            coords[2] = location[i,i2];
                        }
                    }
                    x1 += 185;
                }
                if (count == true)
                {
                    x1 = 108;
                    y1 += 51;
                    count = false;
                }
                else
                {
                    x1 = 200;
                    y1 += 51;
                    count = true;
                }
            }
            return coords;
        }
        
        private bool Check(int x1,int y1,int x2,int y2) // Определяет принадлежность точки к шестиугольнику
        {
            const int z= 62;
            int x = Math.Abs(x1 - x2), y = Math.Abs(y1 - y2);

            var py1 = z * 0.86602540378;
            var px2 = z * 0.2588190451;
            var py2 = z * 0.96592582628;

            var p_angle_01 = -x * (py1 - y) - x * y;
            var p_angle_20 = -y * (px2 - x) + x * (py2 - y);
            var p_angle_03 = y * z;
            var p_angle_12 = -x * (py2 - y) - (px2 - x) * (py1 - y);
            var p_angle_32 = (z - x) * (py2 - y) + y * (px2 - x);

            bool is_inside_1 = (p_angle_01 * p_angle_12 >= 0) && (p_angle_12 * p_angle_20 >= 0);
            bool is_inside_2 = (p_angle_03 * p_angle_32 >= 0) && (p_angle_32 * p_angle_20 >= 0);
            return (is_inside_1 || is_inside_2);
        }
 

        public Bitmap Construction(int x)
        {
            Image[] image = new Image[8];
            image[0] = Image.FromFile("mine_winter.png");
            image[1] = Image.FromFile("sawmill_winter.png");
            image[2] = Image.FromFile("farm_winter.png");
            image[3] = Image.FromFile("port_winter.png");
            image[4] = Image.FromFile("plant_winter.png");
            image[5] = Image.FromFile("windturbine_winter.png");
            image[6] = Image.FromFile("casern_winter.png");
            image[7] = Image.FromFile("laboratory_winter.png");
            Bitmap construction = new Bitmap(100, 100);
            graph = Graphics.FromImage(construction);
            graph.DrawImage(image[x], 0, 0);
            return construction;
        }

        public Bitmap AccentuationConstruction(int x)
        {
            Bitmap construction1 = Construction(x);
            graph = Graphics.FromImage(construction1);
            graph.DrawLine(new Pen(Color.Green, 5), 24, 8, 74, 8);
            graph.DrawLine(new Pen(Color.Green, 5), 73, 7, 100, 50);
            graph.DrawLine(new Pen(Color.Green, 5), 99, 50, 74, 91);
            graph.DrawLine(new Pen(Color.Green, 5), 75, 91, 24, 91);
            graph.DrawLine(new Pen(Color.Green, 5), 24, 90, 1, 50);
            graph.DrawLine(new Pen(Color.Green, 5), 0, 50, 24, 8);
            return construction1;
        }
    }
}
