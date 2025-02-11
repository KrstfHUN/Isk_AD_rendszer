using System;

namespace Iskola
{
    public class Ertekeles
    {
        public Diak Diak { get; set; }
        public Tantargy Tantargy { get; set; }
        public int Erdemjegy { get; set; }

        public Ertekeles(Diak diak, Tantargy tantargy, int erdemjegy)
        {
            this.Diak = diak;
            this.Tantargy = tantargy;
            this.Erdemjegy = erdemjegy;
        }

        public void JegyKiirasa()
        {
            Console.WriteLine($"{Diak.Nev} a {Tantargy.Nev} tantárgyból {Erdemjegy}-es érdemjegyet kapott.");
        }
    }
}
