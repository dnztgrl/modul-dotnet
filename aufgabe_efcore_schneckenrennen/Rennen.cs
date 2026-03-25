namespace aufgabe_efcore_schneckenrennen;

public class Rennen
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MaxTeilnehmer { get; set; }
    public List<Rennschnecke> Teilnehmer { get; set; }
    public int Rennstrecke { get; set; }

    public Rennen()
    {
        Teilnehmer = new List<Rennschnecke>();
    }

    public void ZeigeTeilnehmer()
    {
        Console.WriteLine("\n=========== TEILNEHMER ===========");

        foreach (var t in Teilnehmer)
        {
            Console.WriteLine($"🐌 {t.Name,-12} | Speed: {t.MaxGeschwindigkeit}");
        }

        Console.WriteLine("==================================\n");
    }
    
    public void AddRennschnecke(Rennschnecke neueSchnecke)
    {
        if (Teilnehmer.Count < MaxTeilnehmer)
        {
            Teilnehmer.Add(neueSchnecke);
        }
        else
        {
            Console.WriteLine("Die maximale Teilnehmeranzahl ist erreicht!");
        }
    }

    public string Ausgabe()
    {
        string ausgabe =
            $"Name des Rennens: {Name}\nMaximale Teilnehmeranzahl: {MaxTeilnehmer}\nStrecke: {Rennstrecke}\n\n";

        foreach (Rennschnecke teilnehmer in Teilnehmer)
        {
            if (teilnehmer != null)
            {
                ausgabe += teilnehmer.Ausgabe() + "\n";
            }
        }

        return ausgabe;
    }

    public Rennschnecke ErmittleGewinner()
    {
        for (int i = 0; i < Teilnehmer.Count; i++)
        {
            if (Teilnehmer[i].Strecke >= Rennstrecke)
            {
                return Teilnehmer[i];
            }
        }

        return null;
    }

    public void LasseSchneckenKriechen()
    {
        foreach (var teilnehmer in Teilnehmer)
        {
            teilnehmer.Krieche();
            Console.WriteLine($"🐌 {teilnehmer.Name,-12} → Strecke: {teilnehmer.Strecke}");
        }

        Console.WriteLine();
    }

    public void Durchfuehren()
    {
        int runde = 1;
        if (Teilnehmer.Count < 1)
        {
            Console.WriteLine("Das Rennen hat keine Teilnehmer.");
        }
        else if (Teilnehmer.Count < 2)
        {
            Console.WriteLine("Zu wenig Teilnehmer für ein Rennen.");
        }
        else
        {
            while (ErmittleGewinner() == null)
            {
                Console.WriteLine($"------------ Runde {runde} ------------");
                LasseSchneckenKriechen();
                Console.WriteLine();

                runde++;
            }
        }
    }

    public bool IstRennteilnehmer(string schneckenname)
    {
        for (int i = 0; i < Teilnehmer.Count; i++)
        {
            if (Teilnehmer[i].Name == schneckenname)
            {
                return true;
            }
        }

        return false;
    }
}