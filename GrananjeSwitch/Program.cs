using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrananjeSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            switch (a)
            {
                case 1:
                    Console.WriteLine("jedan");
                    break;
                case 2:
                    Console.WriteLine("dva");
                    break;
                case 3:
                    Console.WriteLine("tri");
                    break;
                case 4:
                    Console.WriteLine("četiri");
                    break;
                default:
                    Console.WriteLine("Nešto što je veće od 4 ili negativno");
                    break;
            }

            if (a == 4) Console.WriteLine("JE");
            else Console.WriteLine("Nije");

            switch (a == 4)
            {
                case true:
                    Console.WriteLine("Je");
                    break;
                case false:
                default:
                    Console.WriteLine("Nije");
                    break;

            }

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("do 3");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("4 do 6");
                    break;
                default :
                    Console.WriteLine("7 i više ...");
                    break;
            }

        }
    }
}
