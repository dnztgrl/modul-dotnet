namespace aufgabe_events_trigger;

// Delegate für die Bedingung - nimmt den Zählerstand und gibt true/false zurück
public delegate bool BedingungHandler(int zaehlerstand);

// EventHandler für die Aktion
public delegate void AktionEventHandler(object sender, CounterEventArgs e);

public class Counter
{
    private int _zaehlerstand;
    private BedingungHandler _bedingung;
    
    public event AktionEventHandler Aktion;

    public int Zaehlerstand
    {
        get { return _zaehlerstand; }
    }
    
    // Bedingung und Aktion werden von außen übergeben
    public Counter(BedingungHandler Bedingung)
    {
        _bedingung = Bedingung;
    }
    
    // Erhöht den Zählerstand und prüft dann, ob die Bedingung erfüllt ist
    public void ZaehlerstandErhoehen(int x)
    {
        _zaehlerstand += x;
        if (_bedingung(_zaehlerstand))
        {
            Aktion?.Invoke(this, new CounterEventArgs(_zaehlerstand));
        }
    }

    // Setzt Zählerstand auf 0 zurück
    public void Clear()
    {
        _zaehlerstand = 0;
    }
}