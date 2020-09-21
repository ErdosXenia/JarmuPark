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

        public double UZA
        {
            get { return uzemanyag; }
        }

        private double fogyaszt;
        private double km;

        public double KM 
        {
            get { return km; } 
        }

        private double megtehetokm;

        public double MEGTKM 
        { 
            get { return megtehetokm; } 
        }

        public auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemanyag = 0;
            this.km = 0;
            this.megtehetokm = 0;
        }

        private void Megteheto()
        {
            megtehetokm = uzemanyag / fogyaszt * 100;
        }

        public void Tankol(double mennyit)
        {
            uzemanyag += mennyit;

            Megteheto();

        }

        public void Megy(double km)
        {
            this.km += km;
            uzemanyag -= (km * fogyaszt / 100);

            Megteheto();

        }

        public void Allapot()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemanyag} l");
            Console.WriteLine($"Megtehető km: {megtehetokm}");
            Console.WriteLine("----------------------------");
        }
    }
}
