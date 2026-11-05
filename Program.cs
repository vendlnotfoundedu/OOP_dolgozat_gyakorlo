using OOP_dolgozat_gyakorlo;
List<Eszkoz> eszkozok = new List<Eszkoz>();

if (File.Exists("eszkozok.txt"))
{
    foreach (string sor in File.ReadAllLines("eszkozok.txt"))
    {
        if (string.IsNullOrWhiteSpace(sor)) continue;
        string[] adatok = sor.Split(';');
        int db = adatok.Count();
        string azonosito = adatok[0];
        string nev = adatok[1];
        string kategoria = adatok[2];
        if (db == 4)
        {
            if (int.TryParse(adatok[3], out int napiDij))
            {
                Eszkoz aktualis = new Eszkoz(azonosito, nev, kategoria, napiDij);
                eszkozok.Add(aktualis);
            }
            else Console.WriteLine($"Hibás napi díj az alábbi sorban: {sor}");
        }
        else if (db == 5)
        {
            if (int.TryParse(adatok[3], out int napiDij) && int.TryParse(adatok[4], out int keszlet))
            {
                Eszkoz aktualis = new Eszkoz(azonosito, nev, kategoria, napiDij, keszlet);
                eszkozok.Add(aktualis);
            }
            else Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú eszköz adatai hibásak, átugorva!");
        }
    }
}
else Console.WriteLine("Az eszkozok.txt nevű fájl nem található!");
Console.WriteLine("=== BEOLVASOTT ESZKÖZÖK ===\n");
foreach (Eszkoz eszkoz in eszkozok) Console.WriteLine(eszkoz);
Console.WriteLine($"\nA rendszerben regsisztrált eszközök száma: {Eszkoz.OsszesRegisztraltEszkoz}");
int osszbevetel = 0;
foreach(Eszkoz eszkoz in eszkozok)
{
    osszbevetel += (eszkoz.NapiDij * eszkoz.Keszlet);
}
Console.WriteLine($"Az eszközpark 1 napra eső teljes bérleti bevétele {osszbevetel} Ft\n");
int legdragabb = 0;
foreach(Eszkoz eszkoz in eszkozok)
{

}
Console.WriteLine($"Legdrágább napi díjú eszköz: {eszkozok.MaxBy( eszk => eszk.NapiDij)}");
