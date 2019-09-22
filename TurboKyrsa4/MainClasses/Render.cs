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
        bool[,] A = new bool[15, 7];
        Bitmap map = new Bitmap(1280, 960);
        Graphics graph;

        public Bitmap RenderMap()  // Главная функция отрисовки карты.
        {
            int x=179, y=50;
            graph = Graphics.FromImage(map);
            Image globalmap = Image.FromFile("MAP V1.jpg");
            Image town1 = Image.FromFile("Town1.png");
            graph.DrawImage(globalmap, 1, 1, 1279, 959);
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    graph.DrawImage(town1, x, y, 123, 123); // ИЗМЕНИТЬ НАЗВАНИЕ КАРТИНКИ,ИНИЦИЛИЗИРОВАТЬ ЕЕ,НАЙТИ КООРДИНАТЫ ПОД НЕЕ,ИЗМЕНИТЬ ДЛИННУ И ВЫСОТУ,ДОБАВИТЬ X И Y ДЛЯ ДРУГИХ ОТРИСОВОК (town1, 180, 50, 120, 120)
                    x += 178;
                }
            }
            return map;
        }


        public bool[,] GetTowns()  // Функция для отрисовки городов на карте.
        {
            return A;
        }

        public void SetTowns(bool[,] B) // Функция для постройки города,на вход пускаем массив с построенными городами.
        {
            A = B;
        }

    }
}
