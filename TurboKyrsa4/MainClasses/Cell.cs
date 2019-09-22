using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboKyrsa4
{
    public class Cell //Класс отвечающий за ячейки
    {
        public bool town;

        public Cell()
        {

        }

        public Cell(bool town) // Конструктор класса
        {
            this.town = town;
        }

        public void Set(bool bild) // Функция установки значения нахождения города в ячейке
        {
            town = bild;
        }

        public bool Get() // Функция получения значения о нахождения города в ячейке
        {
            return town;
        }


    }
}
