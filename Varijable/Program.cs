using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            string unos=Console.ReadLine();
            int broj=int.Parse(unos);

            Console.Write("Unesite decimalni broj: ");
            float decimalni=float.Parse(Console.ReadLine());

            Console.WriteLine(broj+", "+decimalni);

            // broj=(int)decimalni;

            broj = 2_000_123_456;
            decimalni=broj;
            Console.WriteLine(broj + ", " + decimalni.ToString("F2"));

            broj = 2_000_123_457;
            decimalni = broj;
            Console.WriteLine(broj + ", " + decimalni.ToString("F2"));

        }
    }
}
