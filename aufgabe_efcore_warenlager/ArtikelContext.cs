using Microsoft.EntityFrameworkCore;

namespace aufgabe_efcore_warenlager;

public class ArtikelContext : DbContext
{
    // Tabelle Artikel in der Datenbank
    public DbSet<Artikel> Artikel { get; set; }
    
    // Datenbankverbindung (mit SQLite)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Datenbankdatei wird lokal erstellt
        optionsBuilder.UseSqlite("Data Source=warenlager.db");
    }

    
    public void LoadFromFile()
    {
        if (!File.Exists("Warenlager.txt"))
        {
            Console.WriteLine("Datei nicht gefunden!");
            return;
        }

        // Duplikate vermeiden
        if (Artikel.Count() > 0)
        {
            return;
        }
        
        try
        {
            string[] lines = File.ReadAllLines("Warenlager.txt");
            foreach (var line in lines)
            {
                string[] parts = line.Split(';');

                // Hat die Zeile die richtige Anzahl an Werten?
                if (parts.Length != 7)
                {
                    continue;
                }

                if (
                    // Alle Artikel umwandeln
                    // Nur wenn alle Werte korrekt umgewandelt werden, wird der Artikel angelegt
                    int.TryParse(parts[0], out int artikelnummer) &&
                    int.TryParse(parts[2], out int istbestand) &&
                    int.TryParse(parts[3], out int hoechstbestand) &&
                    decimal.TryParse(parts[4], out decimal preis) &&
                    int.TryParse(parts[5], out int verbrauchprotag) &&
                    int.TryParse(parts[6], out int bestelldauer)
                )
                {
                    Artikel artikel = new Artikel()
                    {
                        // Primary Key
                        Id = artikelnummer,
                        
                        Bezeichnung = parts[1],
                        IstBestand = istbestand,
                        Hoechstbestand = hoechstbestand,
                        Preis = preis,
                        VerbrauchProTag = verbrauchprotag,
                        Bestelldauer = bestelldauer
                    };

                    Artikel.Add(artikel);
                }

                else
                {
                    Console.WriteLine($"Ungültige Zeile: {line}");
                }
            }
            // Änderungen in die Datenbank speichern
            SaveChanges();
        }

        catch (Exception ex)
        {
            Console.WriteLine("Fehler: " + ex.Message);
        }
    }

    public decimal GetWarenwert()
    {
        // LAMBDA: Summe der Artikel
        return Artikel.Sum(a => a.Preis * a.IstBestand);
    }
}