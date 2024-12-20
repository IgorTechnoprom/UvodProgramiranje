/* Ovdje stavljamo generalne informacije o datoteci
 * Mogu biti logovi, upute ili nešta slično
 * U nastavi bude tekst zadatka koji treba napraviti
 */

using System;

namespace PrvaAplikacija
{
    /// <summary>
    /// class opis
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Šturi opis metode
        /// </summary>
        /// <param name="args">Parametar koji se inače predaje preko konzole pozivom</param>
        static void Main(string[] args)
        {
            //linijski komentar
            Console.WriteLine("Pozdrav svima :)"); //način ispisa poruke na konzoli
            Console.WriteLine("Nova linija");
            //TODO: Napraviti glavni dio programa.

            int broj_prvi = 42;
            int hb = 0x2A;
            byte bb = 0b_0010_1010;

            Console.WriteLine("\n ---\nbyte bb = 0b_0010_1010; varijabla broj_prvi = " + broj_prvi + "\nint hb = 0x2A; Varijabla hb = " + hb + "\nint broj_prvi = 42; varijabla bb =" + bb);

            double d = 3D;
            Console.WriteLine("\n --\ndouble d = 3D, varijabla d = " + d);

            d = 3.956_345;
            Console.WriteLine("d = 3.956_345; varijabla d = " + d);
            

            float f = 3.12f;

            Console.WriteLine("\n --\nfloat f = 3.12f; " + f);

            decimal g = 3.54M;

            Console.WriteLine("\n --\ndecimal g = 3.54M; " + g);

            d = 0.34e2;

            Console.WriteLine("\n --\nd = 0.34e2; " + "(decimal)d) = " + (decimal)d + " d = " + d);

            d = 1.43e9;
            Console.WriteLine("d = 1.43e9; " + "(decimal)d) = " + (decimal)d + " d = " + d);

            bool izraz = true;
            Console.WriteLine("\n --\nbool izraz = true; " + izraz);

            char c1 = 'j';
            char c2 = '\u006A';
            char c3 = '\x006A';
            char c4 = (char)106;

            Console.WriteLine("\n ---\nchar c1 = 'j'; " + c1 + "\nchar c2 = '\\u006A'; " + c2 + "\nchar c3 = '\\x006A'; " + c3 + " \nchar c4 = (char)106; " + c4);

            Console.WriteLine("\n ---\n\"č itat\"");

            Console.WriteLine("\n ---\nNovi red\n\tDrugi red");

            double r = 3, pi = 3.13, O, P;
            Console.WriteLine("\n ---\ndouble r = 3, pi = 3.14, O, P;" + r + " r " + pi + " pi");
            //Console.WriteLine("\nDuljina polumjera r = " + r + "pi = " + pi + "Opseg O = " + O + "Površina P = " + P); //Use of unassigned local variable 'O' i 'P'

            P = r * r * pi;
            
            Console.WriteLine("\nPovršina kruga računa se prema formuli P = r * r * pi gdje je " + P + " P = " + r + " r " + " * " + r + " r " + " * " + pi + " pi ");

            O = r * r * pi;
            Console.WriteLine("\nOpseg kruga računa se prema formuli O = r * r * pi gdje je " + O + " O = " + r + " r " + " * " + r + " r " + " * " + pi + " pi ");

            Console.WriteLine("\nDuljina polumjera r = " + r + " cm pi = " + pi + "Opseg O = " + O + " cm Površina P = " + P + " cm");

            int h = 3, j = 2;
            Console.WriteLine(h / j);
            Console.WriteLine((float)h / j);
            int k = 200000000;
            Console.WriteLine(k * k);

            long l = k;
            Console.WriteLine(l * l);

            // TODO: nastavak rada

            Console.ReadLine();  //Čeka pritisak entera za kraj programa

        }
    }
}
