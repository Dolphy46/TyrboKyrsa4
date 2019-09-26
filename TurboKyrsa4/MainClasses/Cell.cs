using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboKyrsa4
{
    public class Cell //Класс отвечающий за ячейки
    {
        public bool bilding;

        public Cell()
        {

        }

        public Cell(bool town) // Конструктор класса
        {
            this.bilding = bilding;
        }

        public void Set(bool bild) // Функция установки значения нахождения города в ячейке
        {
            bilding = bild;
        }

        public bool Get() // Функция получения значения о нахождения города в ячейке
        {
            return bilding;
        }

        bool[,] map = new bool[15, 7];
        int[,] location = new int[15, 7];

        public void InfoAboutMap()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    map[i, i2] = true;
                }
            }
            map[7, 6] = true;
            map[0, 1] = false;
            map[0,4] = false;
            map[0,5] = false;
            map[1, 3] = false;
            map[1, 4] = false;
            map[1, 5] = false;
            map[2, 5] = false;
            map[3, 0] = false;
            map[3, 3] = false;
            map[3, 5] = false;
            map[4, 4] = false;
            map[4, 5] = false;
            map[5, 0] = false;
            map[5, 5] = false;
            map[6, 0] = false;
            map[8, 0] = false;
            map[8, 5] = false;
            map[9, 5] = false;
            map[10, 4] = false;
            map[10, 5] = false;
            map[11, 0] = false;
            map[11, 1] = false;
            map[11, 5] = false;
            map[11, 5] = false;
            map[11, 2] = false;
            map[12, 0] = false;
            map[12, 4] = false;
            map[12, 1] = false;
            map[12, 5] = false;
            map[13, 0] = false;
            map[13, 1] = false;
            map[14, 0] = false;
            map[14, 1] = false;
            map[14, 3] = false;
            map[14, 5] = false;
        }

        public void SetinfoAboutMap(bool[,] info)
        {
            map = info;
        }

        public bool[,] GetinfoAboutMap()
        {
            return map;
        }

        public int[,] GetLocation()
        {
            // 0-полностью зеленая ячейка без растительности,1-зеленая ячейка с растительностью, 2-гора №1, 3-Гора №2, 4-Гора №3, 5-Гора №4, 6-Строение(т.к. строений будет больше,то отвлетвлений будет тоже больше)
            location[0, 0] =1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;

            location[0, 0] = 1;
            location[0, 1] = 1;
            location[0, 2] = 1;
            location[0, 3] = 1;
            location[0, 4] = 1;
            location[0, 5] = 1;
            location[0, 6] = 1;
            return location;
        }

        public void SetLocation(int[,] newlocation)
        {
            location = newlocation;
        }
    }
}
