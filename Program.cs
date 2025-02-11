using System;
using System.Collections.Generic;
using Iskola;

class Program
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
            Console.WriteLine("4 - Érdemjegyek kiírása");
            Console.WriteLine("5 - Tantárgyak listázása");
            Console.WriteLine("6 - Új érdemjegy rögzítése");
            Console.WriteLine("7 - Kilépés");

            string valasztas = Console.ReadLine();
            switch (valasztas)
            {
                case "1":
                    Console.Write("Add meg a diák nevét: ");
                    string nev = Console.ReadLine();
                    Console.Write("Add meg a diák azonosítóját: ");
                    if (int.TryParse(Console.ReadLine(), out int azonosito))
                    {
                        Diak ujDiak = new Diak(nev, "10.A", azonosito);
                        osztaly.HozzaadDiak(ujDiak);
                        Console.WriteLine("Diák sikeresen hozzáadva!");
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen azonosító!");
                    }
                    break;

                case "2":
                    osztaly.OsszesDiakListazasa();
                    break;

                case "3":
                    osztaly.OsztalyfonokKiirasa();
                    break;

                case "4":
                    osztaly.ErdemjegyekKiirasa();
                    break;

                case "5":
                    osztalyfonok.OktatottTantargyak();
                    break;

                case "6":
                    Console.Write("Add meg a diák azonosítóját: ");
                    if (!int.TryParse(Console.ReadLine(), out int keresettAzonosito))
                    {
                        Console.WriteLine("Érvénytelen bemenet!");
                        break;
                    }

                    Diak keresettDiak = osztaly.Diakok.Find(d => d.Azonosito == keresettAzonosito);

                    if (keresettDiak == null)
                    {
                        Console.WriteLine("Nem található ilyen diák!");
                        break;
                    }

                    Console.WriteLine("Válaszd ki a tantárgyat:");
                    for (int i = 0; i < osztalyfonok.Tantargyak.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {osztalyfonok.Tantargyak[i].Nev}");
                    }

                    if (int.TryParse(Console.ReadLine(), out int tantargyIndex) &&
                        tantargyIndex > 0 && tantargyIndex <= osztalyfonok.Tantargyak.Count)
                    {
                        Tantargy kivalasztottTantargy = osztalyfonok.Tantargyak[tantargyIndex - 1];
                        Console.Write("Add meg az érdemjegyet (1-5): ");
                        if (int.TryParse(Console.ReadLine(), out int jegy) && jegy >= 1 && jegy <= 5)
                        {
                            osztaly.HozzaadErtekeles(keresettDiak, kivalasztottTantargy, jegy);
                        }
                        else
                        {
                            Console.WriteLine("Érvénytelen jegy!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen tantárgyválasztás!");
                    }
                    break;

                case "7":
                    Console.WriteLine("Kilépés...");
                    return;

                default:
                    Console.WriteLine("Érvénytelen választás, próbáld újra!");
                    break;
            }
        }
    }
}
