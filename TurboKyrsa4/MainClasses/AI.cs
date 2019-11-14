using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboKyrsa4.Forms;

namespace TurboKyrsa4.MainClasses
{
    class AI
    {
        //2 - Washington, 5 - mountain_tundra, 16 - tundra_1, 17 - tundra_2, 18 - tundra_3, 19 - tundra_4,
        //33 - mine_tundra, 34 - sawmill_tundra, 35 - farm_tundra, 36 - plant_tundra, 37 - windturbine_tundra, 38 - casern_tundra
        //39 - port_tundra, 40 - laboratory_tundra (АМЕРИКА)

        //0-Dubai, 3 - mountain_savannah, 8 - savannah_1, 9 - savannah_2, 10 - savannah_3, 11 - savannah_4,
        //41 - mine_savannah, 42 - sawmill_savannah, 43 - farm_savannah, 44 - windturbine_savannah, 45 - ptant_savannah,
        //46 - casern_savannah, 47 - port_savannah, 48 - laboratory_savannah (ДУБАИ)

        Render game;
        Resources resourcesA = new Resources(); //экземпляр где будут хранить данные по ресурсам Америки
        Resources resourcesD = new Resources(); //экземпляр где будут хранить данные по ресурсам Дубая
        private int moves;

        public Render GetRender(Render r) //записывает экземпляр класса Render, который используется в игре
        {
           return game = r;
        }

        public void GetMoves(int m) //узанет какой ход по счёту в игре
        {
            moves = m;
        }
    }
}
