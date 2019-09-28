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
                for (int i2 = 0; i2 < 7; i2++)
                {
                    map[i, i2] = true;
                }
            }
            
            map[0, 1] = false;
            map[0,4] = false;
            map[0,5] = false;
            map[0, 6] = false;
            map[1, 3] = false;
            map[1, 4] = false;
            map[1, 5] = false;
            map[1, 6] = false;
            map[2, 5] = false;
            map[2, 6] = false;
            map[3, 0] = false;
            map[3, 3] = false;
            map[3, 5] = false;
            map[3, 6] = false;
            map[4, 4] = false;
            map[4, 5] = false;
            map[4, 6] = false;
            map[5, 0] = false;
            map[5, 5] = false;
            map[5, 6] = false;
            map[6, 0] = false;
            map[6, 6] = false;
            map[8, 0] = false;
            map[8, 5] = false;
            map[8, 6] = false;
            map[9, 5] = false;
            map[9, 6] = false;
            map[10, 4] = false;
            map[10, 5] = false;
            map[10, 6] = false;
            map[11, 0] = false;
            map[11, 1] = false;
            map[11, 2] = false;
            map[11, 5] = false;
            map[11, 6] = false;
            map[12, 0] = false;
            map[12, 4] = false;
            map[12, 1] = false;
            map[12, 5] = false;
            map[12, 6] = false;
            map[13, 0] = false;
            map[13, 1] = false;
            map[13, 6] = false;
            map[14, 0] = false;
            map[14, 1] = false;
            map[14, 3] = false;
            map[14, 5] = false;
            map[14, 6] = false;
        }

        public void SetinfoAboutMap(bool[,] info)
        {
            map = info;
        }

        public bool[,] GetinfoAboutMap()
        {
            return map;
        }

        public void InfoAboutLocation()
        {
            // 0-Dubai, 1 - Moscow, 2 - NewYork, 3 - mountain_savannah, 4 - mountain_tropics, 5 - mountain_tundra, 6 - mountain_winter_1, 
            // 7 - mountain_winter_2, 8 - savannah_1, 9 - savannah_2, 10 - savannah_3, 11 - savannah_4, 
            // 12 - tropics_1, 13 - tropics_2, 14 - tropics_3, 15 - tropics_4, 16 - tundra_1, 17 - tundra_2, 18 - tundra_3,
            // 19 - tundra_4, 20 - winter_1, 21 - winter_2, 22 - winter_3, 23 - winter_4, ( -1 = нет никакой ячейки)

            location[0, 0] = 1;
            location[0, 2] = 20;
            location[0, 3] = 5;

            location[1, 0] = 6;
            location[1, 1] = 23;
            location[1, 2] = 21;

            location[2, 0] = 20;
            location[2, 1] = 22;
            location[2, 2] = 14;
            location[2, 3] = 5;
            location[2, 4] = 16;

            location[3, 0] = -1;
            location[3, 1] = 22;
            location[3, 2] = 23;
            location[3, 4] = 17;

            location[4, 0] = 21;
            location[4, 1] = 7;
            location[4, 2] = 13;
            location[4, 3] = 18;
  
            location[5, 1] = 23;
            location[5, 2] = 7;
            location[5, 3] = 14;
            location[5, 4] = 18;

            location[6, 1] = 21;
            location[6, 2] = 12;
            location[6, 3] = 15;
            location[6, 4] = 16;
            location[6, 5] = 2;

            location[7, 0] = 22;
            location[7, 1] = 20;
            location[7, 2] = 15;
            location[7, 3] = 4;
            location[7, 4] = 17;
            location[7, 5] = 18;
            location[7, 6] = 19;

            location[8, 1] = 14;
            location[8, 2] = 4;
            location[8, 3] = 13;
            location[8, 4] = 19;

            location[9, 0] = 14;
            location[9, 1] = 12;
            location[9, 2] = 12;
            location[9, 3] = 15;
            location[9, 4] = 11;
           
            location[10, 0] = 15;
            location[10, 1] = 12;
            location[10, 2] = 9;
            location[10, 3] = 10;
           
            location[11, 3] = 11;
            location[11, 4] = 8;

            location[12, 2] = 3;
            location[12, 3] = 0;

            location[13, 2] = 3;
            location[13, 3] = 10;
            location[13, 4] = 10;
            location[13, 5] = 9;

            location[14, 2] = 11;
            location[14, 4] = 11;


        }

        public int[,] GetLocation()
        {
            return location;
        }

        public void SetLocation(int[,] newlocation)
        {
            location = newlocation;
        }
    }
}
