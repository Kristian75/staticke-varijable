using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp168
{
    class prvaKlasa
    {
        private static int counter = 0;
        private string naziv;

        public prvaKlasa()
        { 
            counter++;
            this.naziv = naziv;
        }
        public static int GetCounter() { return counter; }

        public string GetNaziv() { return naziv; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            prvaKlasa x = new prvaKlasa();
            Console.WriteLine(x.GetNaziv());
            Console.WriteLine("Vrijednost: " + prvaKlasa.GetCounter());

            prvaKlasa y = new prvaKlasa();
            Console.WriteLine(y.GetNaziv());
            Console.WriteLine("Vrijednost: " + prvaKlasa.GetCounter());


            prvaKlasa z = new prvaKlasa();
            Console.WriteLine(z.GetNaziv());
            Console.WriteLine("Vrijednost: " + prvaKlasa.GetCounter());


            Console.ReadKey();
        }
    }
}
