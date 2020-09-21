using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{


    class Program
    {
        static void Main(string[] args)
        {
            auto lada = new auto("piros", "Lada 2112", 11);
            auto trabant = new auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();


            Console.ReadKey();
        }
    }
}
