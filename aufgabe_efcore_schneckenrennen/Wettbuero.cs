namespace aufgabe_efcore_schneckenrennen;

public class Wettbuero
{
    // Primary Key (automatisch von EF erkannt)
    public int Id { get; set; }
    public Rennen Rennen { get; set; }
    public int Faktor { get; set; }
    public List<Wette> Wetten { get; set; }

    public Wettbuero()
    {
        Wetten = new List<Wette>();
    }

    public void WetteAnnehmen(string schneckenName, int wettEinsatz, string spieler)
    {
        if (Rennen.IstRennteilnehmer(schneckenName))
        {
            Wette neueWette = new Wette
            {
                Schneckenname = schneckenName,
                Wetteinsatz = wettEinsatz,
                Spieler = spieler
            };
            Wetten.Add(neueWette);
        }
        else
        {
            Console.WriteLine("Ungültiger Schneckenname.");
        }
    }

    public void RennAblauf()
    {
        Rennen.Durchfuehren();
        Rennschnecke gewinner = Rennen.ErmittleGewinner();
    }

    public string Ausgabe()
    {
        string ausgabe = "=========== WETTBÜRO =========== \n";
        ausgabe += $"Faktor: {Faktor}\n\n";

        ausgabe += "------------ RENNEN ------------\n";
        ausgabe += Rennen.Ausgabe() + "\n";

        ausgabe += "------------ WETTEN ------------\n";

        Rennschnecke gewinner = Rennen.ErmittleGewinner();
        string gewinnerName = null;

        if (gewinner != null)
        {
            gewinnerName = gewinner.Name;
        }

        foreach (Wette wette in Wetten)
        {
            int gewinn = 0;

            if (gewinnerName != null && wette.Schneckenname == gewinnerName)
            {
                gewinn = wette.Wetteinsatz * Faktor;
            }

            ausgabe += $"{wette.Spieler,-10} | Einsatz: {wette.Wetteinsatz,-3} | Schnecke: {wette.Schneckenname,-12} | Gewinn: {gewinn}\n";
        }

        return ausgabe;
    }
}