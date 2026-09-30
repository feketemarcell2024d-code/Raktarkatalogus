using Raktarkatalogus;

List<termek> osszes = new List<termek > ();
Console.WriteLine("=== Raktárkészlet rögzitése === \n");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($" {i + 1} Termék adatai");
    termek ujtermek = new termek();
    Console.WriteLine($"\tNév:");
    string nev = Console.ReadLine();
    Console.Write("\tEgységár (Ft)");
    ujtermek.ar = int.Parse(Console.ReadLine());
    Console.Write("\tMenyiség (Db)");
    ujtermek.mennyiseg = int.Parse(Console.ReadLine());
    osszes.Add(ujtermek);
    Console.WriteLine();
}
Console.WriteLine(osszes.Count);
