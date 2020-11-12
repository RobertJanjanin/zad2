using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Console.WriteLine("Unesi niz znakova: ");
            unos = Console.ReadLine();
            unos = unos.Replace(" ", "_");
            Console.WriteLine("" + unos);


            Console.ReadKey();
        }
    }
}
