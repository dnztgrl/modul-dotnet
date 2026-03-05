namespace aufgabe_zuege;

public class Train
{
    public int Zugnummer { get; private set; }
    public int AnzahlWaggons { get; private set; }

    public Train(int zugnummer, int anzahlWaggons)
    {
        Zugnummer = zugnummer;
        AnzahlWaggons = anzahlWaggons;
    }
}