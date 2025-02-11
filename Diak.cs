using System;

namespace Iskola
{
    public class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        public int Azonosito { get; set; }

        public Diak(string nev, string osztaly, int azonosito)
        {
            this.Nev = nev;
            this.Osztaly = osztaly;
            this.Azonosito = azonosito;
        }

        public void TeljesNevKiirasa()
        {
            Console.WriteLine($"Név: {Nev}\tOsztály: {Osztaly} ");
        }
    }
}
