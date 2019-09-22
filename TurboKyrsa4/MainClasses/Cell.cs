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


    }
}
