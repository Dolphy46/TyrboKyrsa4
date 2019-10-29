using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TurboKyrsa4
{
    public class Cell 
    {
        bool[,] water;
        int[,] map;

        Manager manager = new Manager();

        public void Redraw(int i, int i2, int n)
        {
            map[i, i2] = n;
        }
            // 0-Dubai, 1 - Moscow, 2 - Washington, 3 - mountain_savannah, 4 - mountain_tropics, 5 - mountain_tundra, 6 - mountain_winter_1, 
            // 7 - mountain_winter_2, 8 - savannah_1, 9 - savannah_2, 10 - savannah_3, 11 - savannah_4, 
            // 12 - tropics_1, 13 - tropics_2, 14 - tropics_3, 15 - tropics_4, 16 - tundra_1, 17 - tundra_2, 18 - tundra_3,
            // 19 - tundra_4, 20 - winter_1, 21 - winter_2, 22 - winter_3, 23 - winter_4, 24 - OON ( -1 = нет никакой ячейки)
        public void Inic()
        {
            manager.Load();
            map = manager.GetMap();
            water = manager.GetWater();
        }

        public int[,] GetMap()
        {
            return map;
        }

        public bool[,] GetWater()
        {
            return water;
        }
    }
}
