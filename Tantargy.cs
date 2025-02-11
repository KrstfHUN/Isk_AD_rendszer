using System;

namespace Iskola
{
    public class Tantargy
    {
        public string Nev { get; set; }
        public int KontaktOrak { get; set; }

        public Tantargy(string nev, int kontaktOrak)
        {
            this.Nev = nev;
            this.KontaktOrak = kontaktOrak;
        }

        public void TantargyAdatok()
        {
            Console.WriteLine($"Tantárgy: {Nev}, Heti óraszám: {KontaktOrak}");
        }
    }
}
