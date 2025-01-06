using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjenaSKontrolom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int o, sum = 0, brojac = 0;

            while (true)
            {
                Console.Write("Unesite ocjenu: ");
                o = int.Parse(Console.ReadLine());
                if (o == 0) break;
                if (o < 1 || o > 5)
                {
                    Console.WriteLine("Neispravan unos, niste unijeli ucjenu!");
                    continue;
                }
                sum = sum + o;
                brojac++;
            }

            Console.WriteLine("Prosjek ocjena je "+((float)sum/brojac).ToString("0.00"));
        }
    }
}
