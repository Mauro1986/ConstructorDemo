using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Factuur
    {
        public double BTW;
        public int Id;          //default waarde = 0
        public string Artikel;  //objecten default waarde is NULL
        public double Prijs;

        public Factuur()        // typ ctor tab tab (shortcut voor constructor
        {
            BTW = 21.00;
        }
        public Factuur(int id)
       : this()

        {
            Id = id;
        }
        //public Factuur(int id, string artikel)

        //{
        //    this.Id = id;               //this. dan ben je zeker de juiste
        //    this.Artikel = artikel;
        //    Id = id;                  //is het zelfde als hierboven
        //    Artikel = artikel;

        //}
        public Factuur(int id, string artikel)
            :this(id)
        {
            Id = id;
            Artikel = artikel;
         
        }
        public Factuur(int id, string artikel,double prijs)
            :this(id, artikel, prijs)
        {
            Id = id;              
            Artikel = artikel;
            Prijs = prijs;
        }

    }
}
