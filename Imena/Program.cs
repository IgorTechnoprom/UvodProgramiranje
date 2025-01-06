using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imena
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int broj;
            Console.WriteLine("Unesite broj imena: ");
            broj=int.Parse(Console.ReadLine());

            string[] imena=new string[broj];

            for (int i = 0; i < imena.Length; i++)
            {
                Console.WriteLine("Unesite{0}. ime: ", i + 1);
                imena[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Unijeli ste: ");
            for(int i = 0;i < imena.Length; i++) Console.WriteLine(imena[i]+"\t");

            Array.Sort(imena);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sortirana imena: ");
            for (int i = 0; i < imena.Length; i++) Console.WriteLine(imena[i] + "\t");
        }
    }
}
