using Raktarkatalogus;

List<Termek> termekek = new List<Termek>();

Console.WriteLine("=== Raktárkészlet Rögzítése ===");
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. termék adatai:");

    Console.Write("  Név: ");
    string nev = Console.ReadLine();

    Console.Write("  Egységár (Ft): ");
    int ar = int.Parse(Console.ReadLine());

    Console.Write("  Raktárkészlet (db): ");
    int mennyiseg = int.Parse(Console.ReadLine());

    Termek ujTermek = new Termek
    {
        Nev = nev,
        Ar = ar,
        Mennyiseg = mennyiseg
    };

    termekek.Add(ujTermek);
    Console.WriteLine();
}

Console.WriteLine("Adatok feldolgozása...");
Console.WriteLine("========================================");
Console.WriteLine("Rögzített termék a raktárban:");

int osszertek = 0;
int arOsszeg = 0;

foreach (Termek t in termekek)
{
    int termekErtek = t.Ar * t.Mennyiseg;
    osszertek += termekErtek;
    arOsszeg += t.Ar;

    Console.WriteLine($"  - {t.Nev}: {t.Ar} Ft/db ({t.Mennyiseg} db) -> Érték: {termekErtek} Ft");
}

double atlagAr = (double)arOsszeg / termekek.Count;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Raktár teljes összértéke: {osszertek} Ft");
Console.WriteLine($"Termékek átlagos egységára: {atlagAr:F0} Ft");
Console.WriteLine("========================================");