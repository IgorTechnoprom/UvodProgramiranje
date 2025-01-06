using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjenaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ocjenu: ");
            int ocjena=int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljno");
                    break;
                case 2:
                    Console.WriteLine("Dovoljno");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Neispravan unos, ocjena mora biti u rasponu 1.0 do 5.0");
                    break;
            }

            float pi = 3.142f;

            switch (pi)
            {
                case 3: //pi==3
                    Console.WriteLine("Manje točno");
                    break;
                case 3.1f:
                    Console.WriteLine("Preciznije");
                    break;
                case 3.142f:
                    Console.WriteLine("Točno");
                    break;
                default:
                    Console.WriteLine("?");
                    break;
            }
        }
    }
}
