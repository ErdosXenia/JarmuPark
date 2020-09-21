using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class auto
    {
        private string szin;
        private string tipus;
        private double uzemanyag;
        private double fogyaszt;
        private double km;

        public auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemanyag = 0;
            this.km = 0;
        }

        public void Tankol(double mennyit)
        {
            uzemanyag += mennyit;
        }

        public void Megy(double km)
        {
            this.km += km;
        }

        public void Allapot()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemanyag} l");
            Console.WriteLine("----------------------------");
        }
    }
}
