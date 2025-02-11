using System;
using System.Collections.Generic;

namespace Iskola
{
    public class Osztaly
    {
        public string Nev { get; set; }
        public List<Diak> Diakok { get; set; }
        public Tanar Osztalyfonok { get; set; }

        // Constructor
        public Osztaly(string nev, Tanar osztalyfonok)
        {
            this.Nev = nev;
            this.Diakok = new List<Diak>();
            this.Osztalyfonok = osztalyfonok;
        }

        public void HozzaadDiak(Diak diak)
        {
            if (Diakok.Count < 25)
            {
                Diakok.Add(diak);
            }
            else
            {
                Console.WriteLine("Az osztály tele van, nem lehet új diákot felvenni.");
            }
        }

        public void OsszesDiakListazasa()
        {
            Console.WriteLine($"A(z) {Nev} osztály diákjai:");
            foreach (var diak in Diakok)
            {
                diak.TeljesNevKiirasa();
            }
        }

        public void OsztalyfonokKiirasa()
        {
            Console.WriteLine($"Osztályfőnök: {Osztalyfonok.Nev}");
            Osztalyfonok.OktatottTantargyak();
        }
    }
}
