using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboKyrsa4.Forms
{
    public class Resources
    {
        private int rating = 50; //Рейтинг
        private int money = 10000; //ДЕНЬГИ

        int numberMine = 0; //количество шахт
        int numberSawmill = 0; //количество лесопилок
        int numberFarm = 0; // количество ферм
        bool port = false; // наличие порта
        int numberPlant = 0; // количество заводов
        int numberWindturbine = 0; // количество ветряков
        int numberCasern = 0; // количество казарм
        int numberLaboratory = 0; // количество лабораторий
        private int iron = 0; // количество железа
        private int coal = 0; //количество угля
        private int wood = 0; // количество древесины
        private int uranium = 0; // количество урана
        private int eat = 0; // количество еды
        private int tank = 0; // количество танков
        private int men = 0; // количество солдат
        private int warhead = 0; // колчество боеголовок

        public int InfoRating()
        {
            return rating;
        }

        public void SetNumberResours(int i)
        {
            switch (i)
            {
                case 0:
                    numberMine++;
                    break;
                case 1:
                    numberSawmill++;
                    break;
                case 2:
                    numberFarm++;
                    break;
                case 3:
                    port = true;
                    break;
                case 4:
                    numberPlant++;
                    break;
                case 5:
                    numberWindturbine++;
                    break;
                case 6:
                    numberCasern++;
                    break;
                case 7:
                    numberLaboratory++;
                    break;

            }
        }

        public int[] InfoNumberResours() 
        {
            int[] resourc = new int[8];
            resourc[0] = iron;
            resourc[1] = coal;
            resourc[2] = uranium;
            resourc[3] = wood;
            resourc[4] = eat;
            resourc[5] = tank;
            resourc[6] = men;
            resourc[7] = warhead;
            return resourc;
        }

        public string GetLabel2()
        {
            string str = "";
            str = "Ресурсы: " + "\nЖелезо: " + iron + "\nУголь: " + coal + "\nУран: " + uranium + "\nДерево: " + wood +
                "\nЕда: " + eat + "\nТанк" + tank + "\nСолдаты: " + men + "\nБоеголовка: " + warhead;
            return str;
        }

        public int[] InfoResours()
        {
            int[] resourc = new int[8];
            resourc[0] = numberMine;
            resourc[1] = numberSawmill;
            resourc[2] = numberFarm;
            if(port == true)
            resourc[3] = 1;
            resourc[4] = numberPlant;
            resourc[5] = numberWindturbine;
            resourc[6] = numberCasern;
            resourc[7] = numberLaboratory;

            return resourc;
        }
        
        public string GetLabel3()
        {
            string str = "";
            str = "Количество построек: " + "\nШахты: " + numberMine + "\nЛесопилки: " + numberSawmill + "\nФермы: " + numberFarm + "\nЗаводы: " +
                numberPlant + "\nВетряки: " + numberWindturbine + "\nКазармы: " + numberCasern + "\nЛаборатории: " + numberLaboratory;
            return str;
        }
            

        Random random = new Random();

        public void PlusMine() // определяет сколько в шахте добывается ресурсов за ход
        {
            iron = (iron + random.Next(5, 30)) * numberMine;
            coal = (coal + random.Next(5, 15)) * numberMine;
            uranium = (uranium + random.Next(0, 4)) * numberMine;
        }

        public void PlusSwamill() //определяет сколько в лесопилки добывается ресурсов за ход
        {
            wood = (wood + random.Next(5, 15)) * numberSawmill;
        }

        public void PlusFarm() //определяет сколько на ферме добывается ресурсов за ход
        {
            eat = (eat + random.Next(5, 10)) * numberFarm;
        }

              

    }
}
