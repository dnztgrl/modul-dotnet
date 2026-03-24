namespace aufgabe_efcore_warenlager
{
    public class Artikel
    {
        // Primary Key - wird von EF automatisch erkannt
        public int Id { get; set; }
        
        public string Bezeichnung { get; set; }
        public int IstBestand { get; set; }
        public int Hoechstbestand { get; set; }
        public decimal Preis { get; set; }
        public int VerbrauchProTag { get; set; }
        public int Bestelldauer { get; set; }

        public int GetMeldebestand()
        {
            return VerbrauchProTag * (Bestelldauer + 2);
        }

        public int GetBestellvorschlag()
        {
            int meldebestand = GetMeldebestand();

            if (IstBestand <= meldebestand)
            {
                return meldebestand - IstBestand;
            }

            return 0;
        }

        public override string ToString()
        {
            return
                $"[{Id}] {Bezeichnung,-7} | Bestand: {IstBestand,-7} | Preis: {Preis,-12:C} | Meldebestand: {GetMeldebestand()} | Bestellvorschlag: {GetBestellvorschlag()}";
        }
    }
}