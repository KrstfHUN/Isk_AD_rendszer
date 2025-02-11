using System;
using System.Collections.Generic;

namespace Iskola
{
    public class Tanar
    {
        public string Nev { get; set; }
        public List<Tantargy> Tantargyak { get; set; }
        public int TanarID { get; set; }

        public Tanar(string nev, int tanarID)
        {
            this.Nev = nev;
            this.TanarID = tanarID;
            this.Tantargyak = new List<Tantargy>();
        }

        public void HozzaadTantargy(Tantargy tantargy)
        {
            Tantargyak.Add(tantargy);
        }

        public void OktatottTantargyak()
        {
            Console.WriteLine($"Tantárgyak, amelyeket {Nev} tanít:");
            foreach (var tantargy in Tantargyak)
            {
                tantargy.TantargyAdatok();
            }
        }
    }
}
