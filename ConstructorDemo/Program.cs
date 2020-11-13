using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var factuur = new Factuur();      zelfde maar andere schrijfwijze
            //Factuur factuur = new Factuur();
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);

            //Factuur factuur = new Factuur(200011501);
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.BTW);


            //Factuur factuur = new Factuur(200011501, "Tafel");
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);
            //Console.WriteLine(factuur.BTW);

            Factuur factuur = new Factuur(50000801, "Tafel", 250.50);
            Console.WriteLine(factuur.Id);
            Console.WriteLine(factuur.Artikel);
            Console.WriteLine(factuur.Prijs);
            Console.WriteLine(factuur.BTW);


            //Factuur factuur = new Factuur()
            //{
            //    Id = 4467,
            //    Artikel = "Tafel",
            //    Prijs = 277
            //};

            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);
            //Console.WriteLine(factuur.Prijs);
        }
    }
}
