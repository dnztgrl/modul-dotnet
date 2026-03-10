namespace aufgabe_events_trigger;

public class CounterEventArgs : EventArgs
{
    private int _zaehlerstand;

    // Zählerstand einmalig setzen
    public CounterEventArgs(int zaehlerstand)
    {
        _zaehlerstand = zaehlerstand;
    }

    // Read-only Property für den Zählerstand
    public int Zaehlerstand
    {
        get { return _zaehlerstand;  }
    }
}