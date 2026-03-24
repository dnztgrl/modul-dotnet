using System;

using aufgabe_efcore_warenlager;

namespace Klassenbeziehungen_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DbContext wird am Ende automatisch freigegeben
            using (ArtikelContext atx = new ArtikelContext())
            {
                // Erstellt die Datenbank und Tabellen, falls sie noch nicht existieren
                atx.Database.EnsureCreated();
                
                atx.LoadFromFile();

                Console.WriteLine($"\n===== WARENWERT: {atx.GetWarenwert():C} =====\n");

                foreach (var artikel in atx.Artikel)
                {
                    Console.WriteLine(artikel);
                }
            }
        }
    }
}