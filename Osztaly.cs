using Iskola;

public class Osztaly
{
    public string Nev { get; set; }
    public List<Diak> Diakok { get; set; }
    public Tanar Osztalyfonok { get; set; }
    public List<Ertekeles> Ertekelesek { get; set; }

    public Osztaly(string nev, Tanar osztalyfonok)
    {
        this.Nev = nev;
        this.Diakok = new List<Diak>();
        this.Osztalyfonok = osztalyfonok;
        this.Ertekelesek = new List<Ertekeles>();
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

        public void HozzaadErtekeles(Diak diak, Tantargy tantargy, int jegy)
        {
            Ertekeles ujErtekeles = new Ertekeles(diak, tantargy, jegy);
            Ertekelesek.Add(ujErtekeles);
            Console.WriteLine($"Új jegy hozzáadva: {diak.Nev} -> {tantargy.Nev}: {jegy}");
        }

        public void ErdemjegyekKiirasa()
        {
            Console.WriteLine("\n=== Összes érdemjegy ===");
            foreach (var ertekeles in Ertekelesek)
            {
                ertekeles.JegyKiirasa();
            }
        }
}
