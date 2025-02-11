using Iskola;

namespace Isk_AD_rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>();
            Tanar osztalyfonok = new Tanar("Dr. Fekete Tamás", 1);
            osztalyfonok.HozzaadTantargy(new Tantargy("Magyar nyelv és irodalom", 4));
            osztalyfonok.HozzaadTantargy(new Tantargy("Történelem", 3));
            osztalyfonok.HozzaadTantargy(new Tantargy("Matematika", 5));
            osztalyfonok.HozzaadTantargy(new Tantargy("Fizika", 2));
            osztalyfonok.HozzaadTantargy(new Tantargy("Etika", 1));

            Osztaly osztaly = new Osztaly("10.A", osztalyfonok);

            while (true)
            {
                Console.WriteLine("\nVálassz egy opciót:");
                Console.WriteLine("1 - Új diák hozzáadása");
                Console.WriteLine("2 - Összes diák listázása");
                Console.WriteLine("3 - Osztályfőnök kiírása");
                Console.WriteLine("4 - Kilépés");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "1":
                        Console.Write("Add meg a diák nevét: ");
                        string nev = Console.ReadLine();
                        Console.Write("Add meg a diák azonosítóját: ");
                        int azonosito = int.Parse(Console.ReadLine());
                        Diak ujDiak = new Diak(nev, "10.A", azonosito);
                        osztaly.HozzaadDiak(ujDiak);
                        Console.WriteLine("Diák sikeresen hozzáadva!");
                        break;

                    case "2":
                        Console.WriteLine("\n=== Osztály adatok ===");
                        osztaly.OsszesDiakListazasa();
                        break;

                    case "3":
                        osztaly.OsztalyfonokKiirasa();
                        break;

                    case "4":
                        Console.WriteLine("Kilépés...");
                        return;

                    default:
                        Console.WriteLine("Érvénytelen választás, próbáld újra!");
                        break;
                }
            }
        }
    }
}
